using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StageManagment.Uc
{
    public partial class UcManageUsercontrols : UserControl
    {
        public UcManageUsercontrols()
        {
            InitializeComponent();

            tabPageArtist.Controls.Add(new UcArtist());
            tabPageProgramStage.Controls.Add(new UcProgramStage());
            tabPagePerformance.Controls.Add(new UcPerformance());
            tabPageTicket.Controls.Add(new UcTicket());
        }

        /// <summary>
        /// reload the usercontrols when a tabpage changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlMain.SelectedTab == tabPageArtist)
            {
                tabPageArtist.Controls.Clear();
                tabPageArtist.Controls.Add(new UcArtist());
            }
            if (tabControlMain.SelectedTab == tabPageProgramStage)
            {
                tabPageProgramStage.Controls.Clear();
                tabPageProgramStage.Controls.Add(new UcProgramStage());
            }
            if (tabControlMain.SelectedTab == tabPagePerformance)
            {
                tabPagePerformance.Controls.Clear();
                tabPagePerformance.Controls.Add(new UcPerformance());
            }
            if (tabControlMain.SelectedTab == tabPageTicket)
            {
                tabPageTicket.Controls.Clear();
                tabPageTicket.Controls.Add(new UcTicket());
            }
        }
    }
}
