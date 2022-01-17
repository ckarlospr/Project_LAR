using DPUruNet;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Lector
{
	public partial class FormReader_Select : Form
	{
		int opcion = 0;
		
		private ReaderCollection _readers;

        private FormMain _sender;

        public FormMain Sender
        {
            get { return _sender; }
            set { _sender = value; }
        }
    
        private Reader _reader;

        public Reader CurrentReader
        {
            get { return _reader; }
            set { _reader = value; }
        }
		
		public FormReader_Select()
		{
			InitializeComponent();
		}
		
		public FormReader_Select(int opcion)
		{
			InitializeComponent();
			this.opcion = opcion;
		}
		
		void BtnRefreshClick(object sender, System.EventArgs e)
		{
			cboReaders.Text = string.Empty;
            cboReaders.Items.Clear();
            cboReaders.SelectedIndex = -1;

            _readers = ReaderCollection.GetReaders();

            foreach (Reader Reader in _readers)
            {
                cboReaders.Items.Add(Reader.Description.SerialNumber);
            }

            if (cboReaders.Items.Count > 0)
            {
                cboReaders.SelectedIndex = 0;
                //btnCaps.Enabled = true;
                btnSelect.Enabled = true;
            }
            else
            {
                btnSelect.Enabled = false;
                //btnCaps.Enabled = false;
            }
		}
		
		void BtnSelectClick(object sender, System.EventArgs e)
		{
			if (_sender.CurrentReader != null)
            {
                _sender.CurrentReader.Dispose();
                _sender.CurrentReader = null;
            }
            _sender.CurrentReader = _readers[cboReaders.SelectedIndex];
            this.Close();
		}
		
		void FormReader_SelectLoad(object sender, System.EventArgs e)
		{
			BtnRefreshClick(this, new System.EventArgs());
			if(opcion==1)
				BtnSelectClick(this, new System.EventArgs());
		}
	}
}
