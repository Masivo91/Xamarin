using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestGrid
{
    public partial class Control : UserControl
    {
        public Control()
        {
            InitializeComponent();
            label1.Text = "Eodem tempore etiam HyCarthaginiensibus victus inopia iam lassatis, ex horreis Romano populo destinatilassatis, ex horreis Romano populo destinatis frumentum dedit, pauloque postea cum provenisset segetum copia, integre sine ulla restituit mora. odem tempore etiam HyCarthaginiensibus victus inopia iam lassatis, ex horreis Romano populo destinatilassatis, ex horreis Romano populo destinatis frumentum dedit, pauloque postea cum provenisset segetum copia, integre sine ulla restituit mora arthaginiensibus victus inopia iam lassatis, ex horreis Romano populo destinatilassatis, ex horreis Romano populo destinatis frumentum dedit, pauloque postea cum provenisset segetum copia, integre sine ulla restituit mora. odem tempore etiam HyCarthaginiensibus victus inopia iam lassatis, ex h";
            label2.Text = "Eodem tempore etiam Hymetii praeclarae indolis viri negotium est actitatum, cuius hunc novimus esse textum. cum Africam pro consule regeret Carthaginiensibus victus inopia iam ";
            this.SizeChanged+=control_SizeChanged;
        }

        void control_SizeChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("STACKSIZE => HEIGHT " + this.Height + " WIDTH " + this.Width);
        }

    }
}
