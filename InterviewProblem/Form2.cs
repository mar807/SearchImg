using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Google.Apis.Customsearch.v1;
using Microsoft.Office.Interop.PowerPoint;

namespace InterviewProblem
{
    public partial class Form2 : Form
    {

        // api and search keys for google custom search api
        const string apiKey = "AIzaSyBCSiIvaFQ9aCZVvo-0pDt2n0fyFIpz1CM";
        const string searchKey = "e43cf40f26be9ddbd";

        public string wordSearch;
        public string title;
        public string description;
        public List<String> imgList {get; set;}
        public ImageList image { get; set; }

        // initializing and getting the title from form 1
        public Form2(string title_val, string descr_val)
        {
            InitializeComponent();
            titleLabel.Text = title_val;
            descrText.Text = descr_val;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // holding positions for form 2
            List<String> imageList = new List<string>();

            CustomsearchService customSearchService = new CustomsearchService(new Google.Apis.Services.BaseClientService.Initializer() { ApiKey = apiKey });
            Google.Apis.Customsearch.v1.CseResource.ListRequest listRequest = customSearchService.Cse.List();

            // .Q is the search query. Word we are searching for
            listRequest.Q = wordSearch;
            // how many requests we are making. default 10
            listRequest.Num = 9;
            // search id 
            listRequest.Cx = searchKey;
            // searching for image type only
            listRequest.SearchType = CseResource.ListRequest.SearchTypeEnum.Image;

            // var search having the specifications we gave to listRequest so we know what we are looking for
            var search = listRequest.Execute();

            ImageList img = new ImageList();
            img.ImageSize = new Size(150, 150);
            img.ColorDepth = ColorDepth.Depth32Bit;
            var i = 0;
            foreach (var result in search.Items)
            {
                // making it able to the user to see the images
                imageList.Add(result.Link);
                imgList = imageList;
                WebClient w = new WebClient();
                byte[] imageByte = w.DownloadData(imageList[i]);
                MemoryStream stream = new MemoryStream(imageByte);
                Image im = Image.FromStream(stream);
                img.Images.Add(im);
                image = img;
                imgView.Items.Add("", i);
                i++;
            }
            imgView.LargeImageList = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // here is where I want to code to output the images on a powerpoint
            // string of the images
            // img.Images.Add(im); this is holding all the images

            // have to call the microsoft library for application since forms and the microsoft library both use Application. Just need to specify
            Microsoft.Office.Interop.PowerPoint.Application pptApplication = new Microsoft.Office.Interop.PowerPoint.Application();

            Presentation pptPresentation = pptApplication.Presentations.Add(Microsoft.Office.Core.MsoTriState.msoTrue);

            for (var i = 0; i < imgList.Count; i++)
            {
                // creating my powerpoint with slides and text
                Microsoft.Office.Interop.PowerPoint.Slides slides;
                Microsoft.Office.Interop.PowerPoint.Slide slide;
                Microsoft.Office.Interop.PowerPoint.TextRange objText;
                Microsoft.Office.Interop.PowerPoint.TextRange descrText;

                Microsoft.Office.Interop.PowerPoint.CustomLayout custLayout= pptPresentation.SlideMaster.CustomLayouts[Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutText];

                slides = pptPresentation.Slides;
                slide = slides.AddSlide(i + 1, custLayout);
                objText = slide.Shapes[1].TextFrame.TextRange;
                descrText = slide.Shapes[2].TextFrame.TextRange;

                // here is where i added the title to the powerpoint
                objText.Text = title;
                // here is where i added the description to the powerpoint
                descrText.Text = description;
                
                Microsoft.Office.Interop.PowerPoint.Shape shape = slide.Shapes[2];
                slide.Shapes.AddPicture(imgList[i], Microsoft.Office.Core.MsoTriState.msoFalse,
                    Microsoft.Office.Core.MsoTriState.msoTrue, shape.Left, shape.Top, shape.Width, shape.Height);
            }
            pptPresentation.SaveAs(@"C:\powerpoint\newPpt.pptx", Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsDefault, Microsoft.Office.Core.MsoTriState.msoTrue);
        }

        private void imgView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}