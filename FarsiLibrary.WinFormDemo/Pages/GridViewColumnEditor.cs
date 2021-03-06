using System;
using System.Data;
using System.IO;
using FarsiLibrary.WinFormDemo.Demo;

namespace FarsiLibrary.WinFormDemo.Pages
{
    public partial class GridViewColumnEditor : DemoBase
    {
        #region Ctor

        public GridViewColumnEditor()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadDataSet();
        }

        private void LoadDataSet()
        {
            StringReader sr = new StringReader(FarsiLibrary.WinFormDemo.Properties.Resources.Employee);
            ds.ReadXml(sr, XmlReadMode.Auto);
        }

        #endregion
    }
}