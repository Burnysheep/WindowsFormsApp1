using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GMap.NET.Entity.OpenStreetMapRouteEntity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

/*
#################################################################
#                             _`				                #
#                          _ooOoo_				                #
#                         o8888888o				                #
#                         88" . "88				                #
#                         (| -_- |)				                #
#                         O\  =  /O				                #
#                      ____/`---'\____				            #
#                    .'  \\|     |//  `.			            #
#                   /  \\|||  :  |||//  \			            #
#                  /  _||||| -:- |||||_  \			            #
#                  |   | \\\  -  /'| |   |			            #
#                  | \_|  `\`---'//  |_/ |			            #
#                  \  .-\__ `-. -'__/-.  /			            #
#                ___`. .'  /--.--\  `. .'___			        #
#             ."" '<  `.___\_<|>_/___.' _> \"".			        #
#            | | :  `- \`. ;`. _/; .'/ /  .' ; |		        #
#            \  \ `-.   \_\_`. _.'_/_/  -' _.' /		        #
#=============`-.`___`-.__\ \___  /__.-'_.'_.-'=================#
                           `= --= -'                    

            TRỜI PHẬT PHÙ HỘ CODE CON KHÔNG BI BUG

          _.-/`)
         // / / )
      .=// / / / )
     //`/ / / / /
     // /     ` /
   ||         /
    \\       /
     ))    .'
         //    /
         /

*/

namespace FlightWaypoint
{
    public partial class UAVFlightWaypoint : Form
    {
        private UdpClient udpClient;
        private UdpClient udpSender = new UdpClient();
        const int udpPort = 8080; // Cổng UDP

        // Mảng lưu dữ liệu nhận
        double[] gpsValues = new double[7];

        // Mảng lưu dữ liệu gửi
        double[] gpsPacket = new double[8];

        private GMapOverlay markers = new GMapOverlay("markers");
        private bool canCreateMarker = false;
        private Point mouseDownPosition;
        private Timer updateTimer;
        double latitude, longitude, latitudeSearch, longitudeSearch, latitudeSet, longitudeSet;
        private bool mouseUpHandled = false, mouseDownHandled = false, isFirstUpdate = true;
        private double? latitudeHome = null;
        private double? longitudeHome = null;
        double newLatitude;
        double newLongitude;

        public UAVFlightWaypoint()
        {
            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap()
        {
            // Thiết lập ban đầu cho bản đồ
            gMapControl1.MapProvider = GMapProviders.OpenStreetMap;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 10;
            gMapControl1.ShowCenter = false;
            gMapControl1.AutoScroll = true;

            // Bật chức năng kéo bản đồ bằng chuột trái
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.Overlays.Add(markers);
            gMapControl1.Position = new PointLatLng(10.776889, 106.700897);

            // Bắt sự kiện chuột
            gMapControl1.MouseDown += gMapControl1_MouseDown;
            gMapControl1.MouseUp += gMapControl1_MouseUp;

            // Cập nhật Timer
            updateTimer = new Timer();
            updateTimer.Interval = 500; // Cập nhật mỗi 500ms
            updateTimer.Tick += UpdateMarkerPosition;
        }

        private void StartUdpListener()
        {
            udpClient = new UdpClient(udpPort);
            udpClient.BeginReceive(new AsyncCallback(ReceiveCallback), null);
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, udpPort);
                byte[] receivedBytes = udpClient.EndReceive(ar, ref remoteEndPoint);

                // Chuyển đổi dữ liệu từ byte[] sang float[]
                float[] receivedData = new float[receivedBytes.Length / 4];
                for (int i = 0; i < receivedData.Length; i++)
                {
                    receivedData[i] = BitConverter.ToSingle(receivedBytes, i * 4);
                }

                Array.Copy(receivedData, gpsValues, 7);

                // Lắng nghe tiếp
                udpClient.BeginReceive(new AsyncCallback(ReceiveCallback), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateMarkerPosition(object sender, EventArgs e)
        {
            // Cập nhật dữ liệu mới từ GPS
            if (gpsValues[0] == 3)
            {
                newLatitude = gpsValues[1];
                newLongitude = gpsValues[2];
            }

            // Kiểm tra xem dữ liệu GPS có thay đổi không
            if (latitude != newLatitude || longitude != newLongitude)
            {
                latitude = newLatitude;
                longitude = newLongitude;

                // Lưu vị trí Home nếu đây là lần đầu tiên nhấn Start
                if (latitudeHome == null || longitudeHome == null)
                {
                    latitudeHome = latitude;
                    longitudeHome = longitude;
                }

                // Xóa marker cũ (nếu có)
                markers.Markers.Clear();

                // Tạo marker mới
                GMapMarker marker = new GMarkerGoogle(
                    new PointLatLng(latitude, longitude),
                    GMarkerGoogleType.red_dot
                );

                // Gán tooltip
                marker.ToolTipText = $"Latitude: {latitude}\nLongitude: {longitude}";

                // Thêm marker mới vào overlay
                markers.Markers.Add(marker);

                // Nếu là lần đầu cập nhật, di chuyển bản đồ đến vị trí này
                if (isFirstUpdate)
                {
                    gMapControl1.Position = marker.Position;
                    isFirstUpdate = false;
                }

                // Cập nhật thông tin GPS lên giao diện
                latitudeRTLabel.Text = gpsValues[1].ToString();
                longitudeRTLabel.Text = gpsValues[2].ToString();
                headingRTLabel.Text = gpsValues[3].ToString();
                altitudeRTLabel.Text = gpsValues[4].ToString();
                temperatureRTLabel.Text = gpsValues[5].ToString();

                // Làm mới bản đồ
                gMapControl1.Refresh();
            }
        }

        private void searchButt_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu hợp lệ từ các TextBox
            if (!ValidateDoubleInput(latitudeTextBox, out latitudeSet) ||
                !ValidateDoubleInput(longitudeTextBox, out longitudeSet))
            {
                return; // Dừng thực hiện nếu có lỗi
            }

            // Thiết lập vị trí ban đầu trên bản đồ
            latitudeSearch = double.Parse(latitudeTextBox.Text.Trim());
            longitudeSearch = double.Parse(longitudeTextBox.Text.Trim());
            gMapControl1.Position = new PointLatLng(latitudeSearch, longitudeSearch);
            gMapControl1.ShowCenter = false;

            // Kiểm tra nếu overlay "markers" đã tồn tại thì xóa tất cả marker cũ
            GMapOverlay markers = gMapControl1.Overlays.FirstOrDefault(o => o.Id == "markers");

            if (markers == null)  // Nếu chưa có overlay "markers", tạo mới
            {
                markers = new GMapOverlay("markers");
                gMapControl1.Overlays.Add(markers);
            }
            else
            {
                markers.Markers.Clear();  // Xóa marker cũ
            }

            // Tạo marker mới
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(latitudeSearch, longitudeSearch),
                GMarkerGoogleType.red_dot
            );

            // Thêm marker mới vào overlay
            markers.Markers.Add(marker);

            // Cập nhật hiển thị bản đồ
            gMapControl1.Refresh();

            // Hiển thị tooltip khi di chuột qua marker
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
        }


        private void exitButt_Click(object sender, EventArgs e)
        {
            // Đóng UDP khi đóng form
            udpClient?.Close();
            updateTimer.Stop();
            Application.Exit();
        }

        private void startButt_Click(object sender, EventArgs e)
        {
            if (!ValidateIPAndPort())
            {
                return; // Nếu không hợp lệ, thoát khỏi phương thức
            }

            isFirstUpdate = true;
            StartUdpListener();
            updateTimer.Start();
            startButt.Enabled = false;
            stopButt.Enabled = true;
        }

        private void createListButt_Click(object sender, EventArgs e)
        {
            // Tìm overlay "markers"
            GMapOverlay markers = gMapControl1.Overlays.FirstOrDefault(o => o.Id == "markers");

            if (markers != null)
            {
                // Xóa toàn bộ marker cũ
                markers.Markers.Clear();
            }

            // Cập nhật lại bản đồ để hiển thị thay đổi
            gMapControl1.Refresh();

            canCreateMarker = true; // Cho phép tạo marker
            createListButt.Enabled = false;
        }

        private void resetButt_Click(object sender, EventArgs e)
        {
            updateTimer.Stop();
            // Xóa tất cả marker trên bản đồ
            markers.Markers.Clear();

            // Đặt lại vị trí bản đồ về vị trí mặc định
            gMapControl1.Position = new PointLatLng(10.776889, 106.700897);
            gMapControl1.Zoom = 10;

            // Xóa dữ liệu trong mảng gpsPacket
            Array.Clear(gpsPacket, 0, gpsPacket.Length);

            // Đảm bảo các nút nhấn có trạng thái phù hợp
            startButt.Enabled = true;
            stopButt.Enabled = false;
            createListButt.Enabled = true;

            canCreateMarker = false;
            mouseUpHandled = false;
            mouseDownHandled = false;
            isFirstUpdate = false;

            MessageBox.Show("Bản đồ và dữ liệu đã được reset!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void homeButt_Click(object sender, EventArgs e)
        {
            if (latitudeHome == null || longitudeHome == null)
            {
                MessageBox.Show("Chưa có vị trí Home! Hãy nhấn Start trước.");
                return;
            }

            // Xóa dữ liệu trong mảng gpsPacket
            Array.Clear(gpsPacket, 0, gpsPacket.Length);

            gpsPacket[0] = 6;
            gpsPacket[1] = (double)latitudeHome;
            gpsPacket[2] = (double)longitudeHome;

            // Kiểm tra nếu overlay "markers" đã tồn tại thì xóa tất cả marker cũ
            GMapOverlay markers = gMapControl1.Overlays.FirstOrDefault(o => o.Id == "markers");

            if (markers == null)  // Nếu chưa có overlay "markers", tạo mới
            {
                markers = new GMapOverlay("markers");
                gMapControl1.Overlays.Add(markers);
            }
            else
            {
                markers.Markers.Clear();  // Xóa tất cả marker cũ
            }

            // Thêm Marker tại vị trí đầu tiên đã lưu
            GMapMarker homeMarker = new GMarkerGoogle(
                new PointLatLng((double)latitudeHome, (double)longitudeHome),
                GMarkerGoogleType.red_dot  // Marker màu xanh lá
            );

            homeMarker.ToolTipText = "Vị trí Home"; // Hiển thị chú thích
            homeMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver; // Chỉ hiện khi di chuột vào

            markers.Markers.Add(homeMarker);

            // Đưa bản đồ về vị trí Home
            gMapControl1.Position = new PointLatLng((double)latitudeHome, (double)longitudeHome);

            // Cập nhật lại bản đồ
            gMapControl1.Refresh();

            // Gửi gpsPacket
            byte[] gpsData = ConvertDoubleArrayToByteArray(gpsPacket);

            // In dữ liệu thô của mảng byte
            Console.WriteLine("Dữ liệu byte gửi đi:");
            Console.WriteLine(BitConverter.ToString(gpsData));

            udpSender.Send(gpsData, gpsData.Length, IPAddressTextBox.Text, Convert.ToInt16(portTextBox.Text));

        }


        private void stopButt_Click(object sender, EventArgs e)
        {
            if (udpClient == null) 
            {
                MessageBox.Show("UDP Client chưa được khởi tạo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát khỏi hàm để tránh lỗi
            }
            else if (udpClient != null)
            {
                udpClient.Close();
                udpClient = null; // Giải phóng bộ nhớ, tránh lỗi dùng lại object đã đóng
            }

            updateTimer.Stop();
            stopButt.Enabled = false;
            startButt.Enabled = true;
        }

        private void sendButt_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateGpsPacket();

                // Gửi gpsPacket
                byte[] gpsData = ConvertDoubleArrayToByteArray(gpsPacket);

                // In dữ liệu thô của mảng byte
                Console.WriteLine("Dữ liệu byte gửi đi:");
                Console.WriteLine(BitConverter.ToString(gpsData));

                udpSender.Send(gpsData, gpsData.Length, IPAddressTextBox.Text, Convert.ToInt16(portTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Địa chỉ IP hoặc cổng Port không hợp lệ", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }

            createListButt.Enabled = true;
            canCreateMarker = true;
        }

        private void UpdateGpsPacket()
        {
            gpsPacket[0] = 5;
            // Duyệt qua danh sách markers và cập nhật gpsPacket từ index 1
            for (int i = 0; i < markers.Markers.Count; i++)
            {
                gpsPacket[(i * 2) + 1] = markers.Markers[i].Position.Lat;
                gpsPacket[(i * 2) + 2] = markers.Markers[i].Position.Lng;
            }

            // In ra console để kiểm tra
            Console.WriteLine("gpsPacket: " + string.Join(", ", gpsPacket));
        }

        private bool ValidateDoubleInput(System.Windows.Forms.TextBox textBox, out double value)
        {
            // Kiểm tra xem nội dung trong TextBox có thể chuyển sang float hay không
            if (double.TryParse(textBox.Text, out value))
            {
                return true; // Dữ liệu hợp lệ
            }
            else
            {
                MessageBox.Show($"Dữ liệu nhập vào ô '{textBox.Name}' không hợp lệ. Vui lòng nhập số thực.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false; // Dữ liệu không hợp lệ
            }
        }

        private void gMapControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (mouseDownHandled) return;  // Ngăn chặn lần gọi thứ hai
            mouseDownHandled = true;
            mouseUpHandled = false;

            mouseDownPosition = e.Location;

            if (!canCreateMarker) return;

            if (e.Button == MouseButtons.Right)
            {
                RemoveMarkerAtPosition(e.Location);
            }
        }

        private void gMapControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseUpHandled) return;  // Ngăn chặn lần gọi thứ hai
            mouseUpHandled = true;
            mouseDownHandled = false;

            if (!canCreateMarker) return; // Nếu chưa nhấn "Create List", không tạo marker

            // Kiểm tra nếu chuột không di chuyển khi nhả ra
            if (mouseDownPosition == e.Location && e.Button == MouseButtons.Left)
            {
                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                AddMarker(point);
            }
        }
        private void AddMarker(PointLatLng point)
        {
            // Giới hạn tối đa 3 markers
            if (markers.Markers.Count >= 3)
            {
                MessageBox.Show("Bạn chỉ có thể tạo tối đa 3 markers!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
            marker.ToolTipText = $"Vị trí: {point.Lat}, {point.Lng}";

            markers.Markers.Add(marker);

            UpdateMarkerLabels(); // Cập nhật lại số thứ tự

            //ShowGpsPacketInMessageBox();

            gMapControl1.Refresh(); // Làm mới bản đồ
        }

        private void ShowGpsPacketInMessageBox()
        {
            string message = "Dữ liệu gpsPacket:\n";
            for (int i = 0; i < gpsPacket.Length; i += 2)
            {
                if (gpsPacket[i + 1] != 0 && gpsPacket[i + 2] != 0)
                    message += $"Marker {i / 2 + 1}: Lat = {gpsPacket[i + 1]}, Lng = {gpsPacket[i + 2]}\n";
            }

            MessageBox.Show(message, "Danh sách Marker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Hàm xóa marker theo vị trí chuột
        private void RemoveMarkerAtPosition(Point mousePos)
        {
            if (markers == null || markers.Markers.Count == 0)
                return;

            PointLatLng clickedPoint = gMapControl1.FromLocalToLatLng(mousePos.X, mousePos.Y);

            double minDistance = 0.01; // Giới hạn khoảng cách để xóa (có thể điều chỉnh)
            GMapMarker markerToRemove = markers.Markers
                .OrderBy(m => GetDistance(m.Position, clickedPoint)) // Sắp xếp theo khoảng cách
                .FirstOrDefault(m => GetDistance(m.Position, clickedPoint) < minDistance); // Tìm marker gần nhất

            if (markerToRemove != null)
            {
                int index = markers.Markers.IndexOf(markerToRemove); // Lấy vị trí của marker bị xóa

                markers.Markers.Remove(markerToRemove); // Xóa marker khỏi bản đồ

                // Dịch dữ liệu gpsPacket[] để không có khoảng trống
                for (int i = index * 2; i < gpsPacket.Length - 2; i++)
                {
                    gpsPacket[i] = gpsPacket[i + 2]; // Dịch dữ liệu lên
                }

                // Xóa dữ liệu dư thừa ở cuối mảng
                gpsPacket[gpsPacket.Length - 2] = 0;
                gpsPacket[gpsPacket.Length - 1] = 0;

                UpdateMarkerLabels(); // Cập nhật lại số thứ tự

                gMapControl1.Refresh(); // Làm mới bản đồ
            }
        }

        // Hàm cập nhật số thứ tự của markers
        private void UpdateMarkerLabels()
        {
            for (int i = 0; i < markers.Markers.Count; i++)
            {
                markers.Markers[i].ToolTipText = $"Marker {i + 1}: {markers.Markers[i].Position.Lat}, {markers.Markers[i].Position.Lng}";
            }
        }

        private double GetDistance(PointLatLng p1, PointLatLng p2)
        {
            return Math.Sqrt(Math.Pow(p1.Lat - p2.Lat, 2) + Math.Pow(p1.Lng - p2.Lng, 2));
        }

        private bool ValidateIPAndPort()
        {
            if (string.IsNullOrWhiteSpace(IPAddressTextBox.Text) || string.IsNullOrWhiteSpace(portTextBox.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ IP và cổng Port.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IPAddress.TryParse(IPAddressTextBox.Text, out _))
            {
                MessageBox.Show("Địa chỉ IP không hợp lệ. Vui lòng nhập đúng định dạng.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IPAddressTextBox.Focus();
                return false;
            }

            if (!int.TryParse(portTextBox.Text, out int port) || port < 1 || port > 65535)
            {
                MessageBox.Show("Cổng phải là một số từ 1 đến 65535.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                portTextBox.Focus();
                return false;
            }

            return true;
        }


        private void UAVFlightWaypoint_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đóng UDP khi đóng form
            udpClient?.Close();
        }

        // Hàm chuyển đổi mảng double thành byte array
        private byte[] ConvertDoubleArrayToByteArray(double[] array)
        {
            int byteSize = array.Length * sizeof(double); // 8 bytes mỗi double
            byte[] byteArray = new byte[byteSize];

            Buffer.BlockCopy(array, 0, byteArray, 0, byteSize); // Chuyển đổi đúng dữ liệu

            return byteArray;
        }
    }
}
