using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop_Operations_Platform.User_Interface.ManagersTools
{
    
    public partial class ViewServFeedbackAndReports : Form
    {
        ManagerClassController controller = new ManagerClassController();
        public ViewServFeedbackAndReports()
        {
            InitializeComponent();
            dataGridView1.DataSource = controller.GetFeedBacks();
            dataGridView2.DataSource = controller.GetIncidentReport();
        }
    }
}
