using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using NTH_Restaurant_Manager.Model;
using NTH_Restaurant_Manager.Repository;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace NTH_Restaurant_Manager
{
    public partial class frmNhanVien : Form
    {
        HinhAnhRepository repository = new HinhAnhRepository();
        MediaFile file;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn hình";
            ofd.Filter = "Image Files(*.jpg) | *.jpg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                pb_HinhAnh.Image = img.GetThumbnailImage(350, 350, null, new IntPtr());
            }

            insertImage();*/

            loadImage();
            
        }

        private async void loadImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn hình";
            ofd.Filter = "Image Files(*.jpg) | *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                pb_HinhAnh.Image = img.GetThumbnailImage(350, 350, null, new IntPtr());
            }

            MemoryStream ms = new MemoryStream();
            pb_HinhAnh.Image.Save(ms, ImageFormat.Jpeg);

            byte[] a = ms.GetBuffer();
            string output = Convert.ToBase64String(a);
            var data = new HinhAnh
            {
                imgURL = output
            };
            var response = await repository.Insert(data);
        }

        private async void insertImage()
        {
            /*MemoryStream ms = new MemoryStream();
            pb_HinhAnh.Image.Save(ms, ImageFormat.Jpeg);

            byte[] a = ms.GetBuffer();
            string output = Convert.ToBase64String(a);
            var data = new HinhAnh
            {
                imgURL = output
            };
            SetResponse response = await client.SetTaskAsync("Image/", data);
            HinhAnh result = response.ResultAs<HinhAnh>();
            MessageBox.Show(result.imgURL);
            retriveImage();*/
        }

        private async void retriveImage()
        {
           /* FirebaseResponse response = await client.GetTaskAsync("Image/");
            HinhAnh image = response.ResultAs<HinhAnh>();

            byte[] b = Convert.FromBase64String(image.imgURL);

            MemoryStream ms = new MemoryStream();
            ms.Write(b, 0, Convert.ToInt32(b.Length));

            Bitmap bm = new Bitmap(ms, false);
            ms.Dispose();

            pb_HinhAnh.Image = bm;*/

            
        }
    }
}
