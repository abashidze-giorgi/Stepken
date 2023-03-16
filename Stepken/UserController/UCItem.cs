namespace Stepken.UserController
{
    public partial class UCItem : UserControl
    {

        public UCItem()
        {
            InitializeComponent();
        }

        public void AddItemCharactersAndValues(Dictionary<string, string> itemPropertye)
        {
            ListBox list = new ListBox();
            foreach (var kv in itemPropertye)
            {
                list.Items.Add($"{kv.Key} - {kv.Value}");
            }
            PropertyPanel.Controls.Add(list);
        }

        private string _imageAddress;

        public string ImageAddress
        {
            get { return _imageAddress; }
            set { _imageAddress = value; Image_item.ImageLocation = value; Image_item.SizeMode = PictureBoxSizeMode.StretchImage; }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; Lbl_Price.Text = value.ToString(); }
        }


    }
}
