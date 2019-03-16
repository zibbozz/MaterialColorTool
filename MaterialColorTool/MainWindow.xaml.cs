using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaterialColorTool
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        public CheatSheetWindow csw = new CheatSheetWindow();

        public string primary = "#FFFFFF";
        public string primarylight = "#FFFFFF";
        public string primarydark = "#FFFFFF";
        public int primaryid = -1;
        public string secondary = "#FFFFFF";
        public string secondarylight = "#FFFFFF";
        public string secondarydark = "#FFFFFF";
        public int secondaryid = -1;
        public string textcolor = "#000000";
        public string secondarytextcolor = "#000000";

        public SolidColorBrush resetbrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3F4349"));

        public string red50string = "#FFEBEE";
        public string red50lightstring = "#FFFFFF";
        public string red50darkstring = "#CCB9BC";
        public SolidColorBrush red50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFEBEE"));

        public string red100string = "#FFCDD2";
        public string red100lightstring = "#FFFFFF";
        public string red100darkstring = "#CB9CA1";
        public SolidColorBrush red100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFCDD2"));

        public string red200string = "#EF9A9A";
        public string red200lightstring = "#FFCCCB";
        public string red200darkstring = "#BA6B6C";
        public SolidColorBrush red200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EF9A9A"));

        public string red300string = "#E57373";
        public string red300lightstring = "#FFA4A2";
        public string red300darkstring = "#AF4448";
        public SolidColorBrush red300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E57373"));

        public string red400string = "#EF5350";
        public string red400lightstring = "#FF867C";
        public string red400darkstring = "#B61827";
        public SolidColorBrush red400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EF5350"));

        public string red500string = "#F44336";
        public string red500lightstring = "#FF7961";
        public string red500darkstring = "#BA000D";
        public SolidColorBrush red500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F44336"));

        public string red600string = "#E53935";
        public string red600lightstring = "#FF6F60";
        public string red600darkstring = "#AB000D";
        public SolidColorBrush red600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E53935"));

        public string red700string = "#D32F2F";
        public string red700lightstring = "#FF6659";
        public string red700darkstring = "#9A0007";
        public SolidColorBrush red700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D32F2F"));

        public string red800string = "#C62828";
        public string red800lightstring = "#FF5F52";
        public string red800darkstring = "#8E0000";
        public SolidColorBrush red800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C62828"));

        public string red900string = "#B71C1C";
        public string red900lightstring = "#F05545";
        public string red900darkstring = "#7F0000";
        public SolidColorBrush red900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B71C1C"));

        public string reda100string = "#FF8A80";
        public string reda100lightstring = "#FFBCAF";
        public string reda100darkstring = "#C85A54";
        public SolidColorBrush reda100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF8A80"));

        public string reda200string = "#FF5252";
        public string reda200lightstring = "#FF867F";
        public string reda200darkstring = "#C50E29";
        public SolidColorBrush reda200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5252"));

        public string reda400string = "#FF1744";
        public string reda400lightstring = "#FF616F";
        public string reda400darkstring = "#C4001D";
        public SolidColorBrush reda400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF1744"));

        public string reda700string = "#D50000";
        public string reda700lightstring = "#FF5131";
        public string reda700darkstring = "#9B0000";
        public SolidColorBrush reda700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D50000"));

        public string pink50string = "#FCE4EC";
        public string pink50lightstring = "#FFFFFF";
        public string pink50darkstring = "#C9B2BA";
        public SolidColorBrush pink50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FCE4EC"));

        public string pink100string = "#F8BBD0";
        public string pink100lightstring = "#FFEEFF";
        public string pink100darkstring = "#C48B9F";
        public SolidColorBrush pink100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F8BBD0"));

        public string pink200string = "#F48FB1";
        public string pink200lightstring = "#FFC1E3";
        public string pink200darkstring = "#BF5F82";
        public SolidColorBrush pink200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F48FB1"));

        public string pink300string = "#F06292";
        public string pink300lightstring = "#FF94C2";
        public string pink300darkstring = "#BA2D65";
        public SolidColorBrush pink300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F06292"));

        public string pink400string = "#EC407A";
        public string pink400lightstring = "#FF77A9";
        public string pink400darkstring = "#B4004E";
        public SolidColorBrush pink400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EC407A"));

        public string pink500string = "#E91E63";
        public string pink500lightstring = "#FF6090";
        public string pink500darkstring = "#B0003A";
        public SolidColorBrush pink500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E91E63"));

        public string pink600string = "#D81B60";
        public string pink600lightstring = "#FF5C8D";
        public string pink600darkstring = "#A00037";
        public SolidColorBrush pink600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D81B60"));

        public string pink700string = "#C2185B";
        public string pink700lightstring = "#FA5788";
        public string pink700darkstring = "#8C0032";
        public SolidColorBrush pink700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C2185B"));

        public string pink800string = "#AD1457";
        public string pink800lightstring = "#E35183";
        public string pink800darkstring = "#78002E";
        public SolidColorBrush pink800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#AD1457"));

        public string pink900string = "#880E4F";
        public string pink900lightstring = "#BC477F";
        public string pink900darkstring = "#560027";
        public SolidColorBrush pink900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#880E4F"));

        public string pinka100string = "#FF80AB";
        public string pinka100lightstring = "#FFB2DD";
        public string pinka100darkstring = "#C94F7C";
        public SolidColorBrush pinka100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF80AB"));

        public string pinka200string = "#FF4081";
        public string pinka200lightstring = "#FF79B0";
        public string pinka200darkstring = "#C60055";
        public SolidColorBrush pinka200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF4081"));

        public string pinka400string = "#F50057";
        public string pinka400lightstring = "#FF5983";
        public string pinka400darkstring = "#BB002F";
        public SolidColorBrush pinka400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F50057"));

        public string pinka700string = "#C51162";
        public string pinka700lightstring = "#FD558F";
        public string pinka700darkstring = "#8E0038";
        public SolidColorBrush pinka700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C51162"));

        public string purple50string = "#F2E4F4";
        public string purple50lightstring = "#FFFFFF";
        public string purple50darkstring = "#BDB2C1";
        public SolidColorBrush purple50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F2E4F4"));

        public string purple100string = "#E1BEE7";
        public string purple100lightstring = "#FFF1FF";
        public string purple100darkstring = "#AF8EB5";
        public SolidColorBrush purple100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E1BEE7"));

        public string purple200string = "#CE93D8";
        public string purple200lightstring = "#FFC4FF";
        public string purple200darkstring = "#9C64A6";
        public SolidColorBrush purple200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CE93D8"));

        public string purple300string = "#BA68C8";
        public string purple300lightstring = "#EE98FB";
        public string purple300darkstring = "#883997";
        public SolidColorBrush purple300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BA68C8"));

        public string purple400string = "#AB47BC";
        public string purple400lightstring = "#DF78EF";
        public string purple400darkstring = "#790E8B";
        public SolidColorBrush purple400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#AB47BC"));

        public string purple500string = "#9C27B0";
        public string purple500lightstring = "#D05CE3";
        public string purple500darkstring = "#6A0080";
        public SolidColorBrush purple500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9C27B0"));

        public string purple600string = "#8E24AA";
        public string purple600lightstring = "#C158DC";
        public string purple600darkstring = "#5C007A";
        public SolidColorBrush purple600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8E24AA"));

        public string purple700string = "#7B1FA2";
        public string purple700lightstring = "#AE52D4";
        public string purple700darkstring = "#4A0072";
        public SolidColorBrush purple700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B1FA2"));

        public string purple800string = "#6A1B9A";
        public string purple800lightstring = "#9C4DCC";
        public string purple800darkstring = "#38006B";
        public SolidColorBrush purple800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6A1B9A"));

        public string purple900string = "#4A148C";
        public string purple900lightstring = "#7C43BD";
        public string purple900darkstring = "#12005E";
        public SolidColorBrush purple900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4A148C"));

        public string purplea100string = "#EA80FC";
        public string purplea100lightstring = "#FFB2FF";
        public string purplea100darkstring = "#B64FC8";
        public SolidColorBrush purplea100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EA80FC"));

        public string purplea200string = "#E040FB";
        public string purplea200lightstring = "#FF79FF";
        public string purplea200darkstring = "#AA00C7";
        public SolidColorBrush purplea200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E040FB"));

        public string purplea400string = "#D500F9";
        public string purplea400lightstring = "#FF5BFF";
        public string purplea400darkstring = "#9E00C5";
        public SolidColorBrush purplea400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D500F9"));

        public string purplea700string = "#AA00FF";
        public string purplea700lightstring = "#E254FF";
        public string purplea700darkstring = "#7200CA";
        public SolidColorBrush purplea700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#AA00FF"));

        public string deeppurple50string = "#EDE7F6";
        public string deeppurple50lightstring = "#FFFFFF";
        public string deeppurple50darkstring = "#BBB5C3";
        public SolidColorBrush deeppurple50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EDE7F6"));

        public string deeppurple100string = "#D1C4E9";
        public string deeppurple100lightstring = "#FFF7FF";
        public string deeppurple100darkstring = "#A094B7";
        public SolidColorBrush deeppurple100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D1C4E9"));

        public string deeppurple200string = "#B39DDB";
        public string deeppurple200lightstring = "#E6CEFF";
        public string deeppurple200darkstring = "#836FA9";
        public SolidColorBrush deeppurple200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B39DDB"));

        public string deeppurple300string = "#9575CD";
        public string deeppurple300lightstring = "#C7A4FF";
        public string deeppurple300darkstring = "#65499C";
        public SolidColorBrush deeppurple300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9575CD"));

        public string deeppurple400string = "#7E57C2";
        public string deeppurple400lightstring = "#B085F5";
        public string deeppurple400darkstring = "#4D2C91";
        public SolidColorBrush deeppurple400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7E57C2"));

        public string deeppurple500string = "#673AB7";
        public string deeppurple500lightstring = "#9A67EA";
        public string deeppurple500darkstring = "#320B86";
        public SolidColorBrush deeppurple500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#673AB7"));

        public string deeppurple600string = "#5E35B1";
        public string deeppurple600lightstring = "#9163E4";
        public string deeppurple600darkstring = "#280680";
        public SolidColorBrush deeppurple600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5E35B1"));

        public string deeppurple700string = "#512DA8";
        public string deeppurple700lightstring = "#8559DA";
        public string deeppurple700darkstring = "#140078";
        public SolidColorBrush deeppurple700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#512DA8"));

        public string deeppurple800string = "#4527A0";
        public string deeppurple800lightstring = "#7953D2";
        public string deeppurple800darkstring = "#000070";
        public SolidColorBrush deeppurple800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4527A0"));

        public string deeppurple900string = "#311B92";
        public string deeppurple900lightstring = "#6746C3";
        public string deeppurple900darkstring = "#000063";
        public SolidColorBrush deeppurple900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#311B92"));

        public string deeppurplea100string = "#B388FF";
        public string deeppurplea100lightstring = "#E7B9FF";
        public string deeppurplea100darkstring = "#805ACB";
        public SolidColorBrush deeppurplea100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B388FF"));

        public string deeppurplea200string = "#7C4DFF";
        public string deeppurplea200lightstring = "#B47CFF";
        public string deeppurplea200darkstring = "#3F1DCB";
        public SolidColorBrush deeppurplea200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7C4DFF"));

        public string deeppurplea400string = "#651FFF";
        public string deeppurplea400lightstring = "#A255FF";
        public string deeppurplea400darkstring = "#0100CA";
        public SolidColorBrush deeppurplea400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#651FFF"));

        public string deeppurplea700string = "#6200EA";
        public string deeppurplea700lightstring = "#9D46FF";
        public string deeppurplea700darkstring = "#0A00B6";
        public SolidColorBrush deeppurplea700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6200EA"));

        public string indigo50string = "#E8EAF6";
        public string indigo50lightstring = "#FFFFFF";
        public string indigo50darkstring = "#B6B8C3";
        public SolidColorBrush indigo50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E8EAF6"));

        public string indigo100string = "#C5CAE9";
        public string indigo100lightstring = "#F8FDFF";
        public string indigo100darkstring = "#9499B7";
        public SolidColorBrush indigo100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C5CAE9"));

        public string indigo200string = "#9FA8DA";
        public string indigo200lightstring = "#D1D9FF";
        public string indigo200darkstring = "#6F79A8";
        public SolidColorBrush indigo200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9FA8DA"));

        public string indigo300string = "#7986CB";
        public string indigo300lightstring = "#AAB6FE";
        public string indigo300darkstring = "#49599A";
        public SolidColorBrush indigo300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7986CB"));

        public string indigo400string = "#5C6BC0";
        public string indigo400lightstring = "#8E99F3";
        public string indigo400darkstring = "#26418F";
        public SolidColorBrush indigo400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5C6BC0"));

        public string indigo500string = "#3F51B5";
        public string indigo500lightstring = "#757DE8";
        public string indigo500darkstring = "#002984";
        public SolidColorBrush indigo500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3F51B5"));

        public string indigo600string = "#3949AB";
        public string indigo600lightstring = "#6F74DD";
        public string indigo600darkstring = "#00227B";
        public SolidColorBrush indigo600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3949AB"));

        public string indigo700string = "#303F9F";
        public string indigo700lightstring = "#666AD1";
        public string indigo700darkstring = "#001970";
        public SolidColorBrush indigo700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#303F9E"));

        public string indigo800string = "#283593";
        public string indigo800lightstring = "#5F5FC4";
        public string indigo800darkstring = "#001064";
        public SolidColorBrush indigo800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#283593"));

        public string indigo900string = "#1A237E";
        public string indigo900lightstring = "#534BAE";
        public string indigo900darkstring = "#000051";
        public SolidColorBrush indigo900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1A237E"));

        public string indigoa100string = "#8C9EFF";
        public string indigoa100lightstring = "#C0CFFF";
        public string indigoa100darkstring = "#5870CB";
        public SolidColorBrush indigoa100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8C9EFF"));

        public string indigoa200string = "#536DFE";
        public string indigoa200lightstring = "#8F9BFF";
        public string indigoa200darkstring = "#0043CA";
        public SolidColorBrush indigoa200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#536DFE"));

        public string indigoa400string = "#3D5AFE";
        public string indigoa400lightstring = "#8187FF";
        public string indigoa400darkstring = "#0031CA";
        public SolidColorBrush indigoa400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3D5AFE"));

        public string indigoa700string = "#304FFE";
        public string indigoa700lightstring = "#7A7CFF";
        public string indigoa700darkstring = "#0026CA";
        public SolidColorBrush indigoa700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#304FFE"));

        public string blue50string = "#E3F2FD";
        public string blue50lightstring = "#FFFFFF";
        public string blue50darkstring = "#B1BFCA";
        public SolidColorBrush blue50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E3F2FD"));

        public string blue100string = "#BBDEFB";
        public string blue100lightstring = "#EEFFFF";
        public string blue100darkstring = "#8AACC8";
        public SolidColorBrush blue100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BBDEFB"));

        public string blue200string = "#90CAF9";
        public string blue200lightstring = "#C3FDFF";
        public string blue200darkstring = "#5D99C6";
        public SolidColorBrush blue200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#90CAF9"));

        public string blue300string = "#64B5F6";
        public string blue300lightstring = "#9BE7FF";
        public string blue300darkstring = "#2286C3";
        public SolidColorBrush blue300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#64B5F6"));

        public string blue400string = "#42A5F5";
        public string blue400lightstring = "#80D6FF";
        public string blue400darkstring = "#0077C2";
        public SolidColorBrush blue400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#42A5F5"));

        public string blue500string = "#2196F3";
        public string blue500lightstring = "#6EC6FF";
        public string blue500darkstring = "#0069C0";
        public SolidColorBrush blue500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2196F3"));

        public string blue600string = "#1E88E5";
        public string blue600lightstring = "#6AB6FF";
        public string blue600darkstring = "#005CB2";
        public SolidColorBrush blue600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E88E5"));

        public string blue700string = "#1976D2";
        public string blue700lightstring = "#63A4FF";
        public string blue700darkstring = "#004BA0";
        public SolidColorBrush blue700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1976D2"));

        public string blue800string = "#1565C9";
        public string blue800lightstring = "#5E92F3";
        public string blue800darkstring = "#003C8F";
        public SolidColorBrush blue800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1565C9"));

        public string blue900string = "#0D47A1";
        public string blue900lightstring = "#5472D3";
        public string blue900darkstring = "#002171";
        public SolidColorBrush blue900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0D47A1"));

        public string bluea100string = "#82B1FF";
        public string bluea100lightstring = "#B6E3FF";
        public string bluea100darkstring = "#4D82CB";
        public SolidColorBrush bluea100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#82B1FF"));

        public string bluea200string = "#448AFF";
        public string bluea200lightstring = "#83B9FF";
        public string bluea200darkstring = "#005ECB";
        public SolidColorBrush bluea200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#448AFF"));

        public string bluea400string = "#2979FF";
        public string bluea400lightstring = "#75A7FF";
        public string bluea400darkstring = "#004ECB";
        public SolidColorBrush bluea400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2979FF"));

        public string bluea700string = "#2962FF";
        public string bluea700lightstring = "#768FFF";
        public string bluea700darkstring = "#0039CB";
        public SolidColorBrush bluea700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2962FF"));

        public string lightblue50string = "#E1F5FE";
        public string lightblue50lightstring = "#FFFFFF";
        public string lightblue50darkstring = "#AFC2CB";
        public SolidColorBrush lightblue50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E1F5FE"));

        public string lightblue100string = "#B3E5FC";
        public string lightblue100lightstring = "#E6FFFF";
        public string lightblue100darkstring = "#82B3C9";
        public SolidColorBrush lightblue100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B3E5FC"));

        public string lightblue200string = "#81D4FA";
        public string lightblue200lightstring = "#B6FFFF";
        public string lightblue200darkstring = "#4BA3C7";
        public SolidColorBrush lightblue200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#81D4FA"));

        public string lightblue300string = "#4FC3F7";
        public string lightblue300lightstring = "#8BF6FF";
        public string lightblue300darkstring = "#0093C4";
        public SolidColorBrush lightblue300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4FC3F7"));

        public string lightblue400string = "#29B6F6";
        public string lightblue400lightstring = "#73E8FF";
        public string lightblue400darkstring = "#0086C3";
        public SolidColorBrush lightblue400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#29B6F6"));

        public string lightblue500string = "#03A9F4";
        public string lightblue500lightstring = "#67DAFF";
        public string lightblue500darkstring = "#007AC1";
        public SolidColorBrush lightblue500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#03A9F4"));

        public string lightblue600string = "#039BE5";
        public string lightblue600lightstring = "#63CCFF";
        public string lightblue600darkstring = "#006DB3";
        public SolidColorBrush lightblue600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#039BE5"));

        public string lightblue700string = "#0288D1";
        public string lightblue700lightstring = "#5EB8FF";
        public string lightblue700darkstring = "#005B9F";
        public SolidColorBrush lightblue700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0288D1"));

        public string lightblue800string = "#0277BD";
        public string lightblue800lightstring = "#58A5F0";
        public string lightblue800darkstring = "#004C8C";
        public SolidColorBrush lightblue800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0277BD"));

        public string lightblue900string = "#01579B";
        public string lightblue900lightstring = "#4F83CC";
        public string lightblue900darkstring = "#002F6C";
        public SolidColorBrush lightblue900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#01579B"));

        public string lightbluea100string = "#80D8FF";
        public string lightbluea100lightstring = "#B5FFFF";
        public string lightbluea100darkstring = "#49A7CC";
        public SolidColorBrush lightbluea100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#80D8FF"));

        public string lightbluea200string = "#40C4FF";
        public string lightbluea200lightstring = "#82F7FF";
        public string lightbluea200darkstring = "#0094CC";
        public SolidColorBrush lightbluea200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#40C4FF"));

        public string lightbluea400string = "#00B0FF";
        public string lightbluea400lightstring = "#69E2FF";
        public string lightbluea400darkstring = "#0081CB";
        public SolidColorBrush lightbluea400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00B0FF"));

        public string lightbluea700string = "#0091EA";
        public string lightbluea700lightstring = "#64C1FF";
        public string lightbluea700darkstring = "#0064B7";
        public SolidColorBrush lightbluea700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0091EA"));

        public string cyan50string = "#E0F7FA";
        public string cyan50lightstring = "#FFFFFF";
        public string cyan50darkstring = "#AEC4C7";
        public SolidColorBrush cyan50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E0F7FA"));

        public string cyan100string = "#B2EBF2";
        public string cyan100lightstring = "#E5FFFF";
        public string cyan100darkstring = "#81B9BF";
        public SolidColorBrush cyan100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B2EBF2"));

        public string cyan200string = "#80DEEA";
        public string cyan200lightstring = "#B4FFFF";
        public string cyan200darkstring = "#4BACB8";
        public SolidColorBrush cyan200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#80DEEA"));

        public string cyan300string = "#4DD0E1";
        public string cyan300lightstring = "#88FFFF";
        public string cyan300darkstring = "#009FAF";
        public SolidColorBrush cyan300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4DD0E1"));

        public string cyan400string = "#26C6DA";
        public string cyan400lightstring = "#6FF9FF";
        public string cyan400darkstring = "#0095A8";
        public SolidColorBrush cyan400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#26C6DA"));

        public string cyan500string = "#00BCD4";
        public string cyan500lightstring = "#62EFFF";
        public string cyan500darkstring = "#008BA3";
        public SolidColorBrush cyan500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00BCD4"));

        public string cyan600string = "#00ACC1";
        public string cyan600lightstring = "#5DDEF4";
        public string cyan600darkstring = "#007C91";
        public SolidColorBrush cyan600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00ACC1"));

        public string cyan700string = "#0097A7";
        public string cyan700lightstring = "#56C8D8";
        public string cyan700darkstring = "#006978";
        public SolidColorBrush cyan700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0097A7"));

        public string cyan800string = "#00838F";
        public string cyan800lightstring = "#4FB3BF";
        public string cyan800darkstring = "#005662";
        public SolidColorBrush cyan800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00838F"));

        public string cyan900string = "#006064";
        public string cyan900lightstring = "#428E92";
        public string cyan900darkstring = "#00363A";
        public SolidColorBrush cyan900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#006064"));

        public string cyana100string = "#84FFFF";
        public string cyana100lightstring = "#BAFFFF";
        public string cyana100darkstring = "#4BCBCC";
        public SolidColorBrush cyana100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#84FFFF"));

        public string cyana200string = "#18FFFF";
        public string cyana200lightstring = "#76FFFF";
        public string cyana200darkstring = "#00CBCC";
        public SolidColorBrush cyana200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#18FFFF"));

        public string cyana400string = "#00E5FF";
        public string cyana400lightstring = "#6EFFFF";
        public string cyana400darkstring = "#00B2CC";
        public SolidColorBrush cyana400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00E5FF"));

        public string cyana700string = "#00B8D4";
        public string cyana700lightstring = "#62EBFF";
        public string cyana700darkstring = "#0088A3";
        public SolidColorBrush cyana700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00B8D4"));

        public string teal50string = "#E0F2F1";
        public string teal50lightstring = "#FFFFFF";
        public string teal50darkstring = "#AEBFBE";
        public SolidColorBrush teal50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E0F2F1"));

        public string teal100string = "#B2DFDB";
        public string teal100lightstring = "#E5FFFF";
        public string teal100darkstring = "#82ADA9";
        public SolidColorBrush teal100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B2DFDB"));

        public string teal200string = "#80CBC4";
        public string teal200lightstring = "#B2FEF7";
        public string teal200darkstring = "#4F9A94";
        public SolidColorBrush teal200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#80CBC4"));

        public string teal300string = "#4DB6AC";
        public string teal300lightstring = "#82E9DE";
        public string teal300darkstring = "#00867D";
        public SolidColorBrush teal300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4DB6AC"));

        public string teal400string = "#26A69A";
        public string teal400lightstring = "#64D8CB";
        public string teal400darkstring = "#00766C";
        public SolidColorBrush teal400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#26A69A"));

        public string teal500string = "#009688";
        public string teal500lightstring = "#52C7B8";
        public string teal500darkstring = "#00675B";
        public SolidColorBrush teal500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#009688"));

        public string teal600string = "#00897B";
        public string teal600lightstring = "#4EBAAA";
        public string teal600darkstring = "#005B4F";
        public SolidColorBrush teal600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00897B"));

        public string teal700string = "#00796B";
        public string teal700lightstring = "#48A999";
        public string teal700darkstring = "#004C40";
        public SolidColorBrush teal700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00796B"));

        public string teal800string = "#00695C";
        public string teal800lightstring = "#439889";
        public string teal800darkstring = "#003D33";
        public SolidColorBrush teal800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00695C"));

        public string teal900string = "#004D40";
        public string teal900lightstring = "#39796B";
        public string teal900darkstring = "#00251A";
        public SolidColorBrush teal900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#004D40"));

        public string teala100string = "#A7FFEB";
        public string teala100lightstring = "#DBFFFF";
        public string teala100darkstring = "#75CCB9";
        public SolidColorBrush teala100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A7FFEB"));

        public string teala200string = "#64FFDA";
        public string teala200lightstring = "#9EFFFF";
        public string teala200darkstring = "#14CBA8";
        public SolidColorBrush teala200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#64FFDA"));

        public string teala400string = "#1DE9B6";
        public string teala400lightstring = "#6EFFE8";
        public string teala400darkstring = "#00B686";
        public SolidColorBrush teala400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1DE9B6"));

        public string teala700string = "#00BFA5";
        public string teala700lightstring = "#5DF2D6";
        public string teala700darkstring = "#008E76";
        public SolidColorBrush teala700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00BFA5"));

        public string green50string = "#E8F5E9";
        public string green50lightstring = "#FFFFFF";
        public string green50darkstring = "#B6C2B7";
        public SolidColorBrush green50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E8F5E9"));

        public string green100string = "#C8E6C9";
        public string green100lightstring = "#FBFFFC";
        public string green100darkstring = "#97B498";
        public SolidColorBrush green100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C8E6C9"));

        public string green200string = "#A5D6A7";
        public string green200lightstring = "#D7FFD9";
        public string green200darkstring = "#75A478";
        public SolidColorBrush green200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A5D6A7"));

        public string green300string = "#81C784";
        public string green300lightstring = "#B2FAB4";
        public string green300darkstring = "#519657";
        public SolidColorBrush green300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#81C784"));

        public string green400string = "#66BB6A";
        public string green400lightstring = "#98EE99";
        public string green400darkstring = "#338A3E";
        public SolidColorBrush green400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#66BB6A"));

        public string green500string = "#4CAF50";
        public string green500lightstring = "#80E27E";
        public string green500darkstring = "#087F23";
        public SolidColorBrush green500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4CAF50"));

        public string green600string = "#43A047";
        public string green600lightstring = "#76D275";
        public string green600darkstring = "#00701A";
        public SolidColorBrush green600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#43A047"));

        public string green700string = "#388E3C";
        public string green700lightstring = "#6ABF69";
        public string green700darkstring = "#00600F";
        public SolidColorBrush green700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#388E3C"));

        public string green800string = "#2E7D32";
        public string green800lightstring = "#60AD5E";
        public string green800darkstring = "#005005";
        public SolidColorBrush green800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2E7D32"));

        public string green900string = "#1B5E20";
        public string green900lightstring = "#4C8C4A";
        public string green900darkstring = "#003300";
        public SolidColorBrush green900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1B5E20"));

        public string greena100string = "#B9F6CA";
        public string greena100lightstring = "#ECFFFD";
        public string greena100darkstring = "#88C399";
        public SolidColorBrush greena100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B9F6CA"));

        public string greena200string = "#69F0AE";
        public string greena200lightstring = "#9FFFE0";
        public string greena200darkstring = "#2BBD7E";
        public SolidColorBrush greena200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#69F0AE"));

        public string greena400string = "#00E676";
        public string greena400lightstring = "#66FFA6";
        public string greena400darkstring = "#00B248";
        public SolidColorBrush greena400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00E676"));

        public string greena700string = "#00C853";
        public string greena700lightstring = "#5EFC82";
        public string greena700darkstring = "#009624";
        public SolidColorBrush greena700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00C853"));

        public string lightgreen50string = "#F1F8E9";
        public string lightgreen50lightstring = "#FFFFFF";
        public string lightgreen50darkstring = "#BEC5B7";
        public SolidColorBrush lightgreen50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F1F8E9"));

        public string lightgreen100string = "#DCEDC8";
        public string lightgreen100lightstring = "#FFFFFB";
        public string lightgreen100darkstring = "#AABB97";
        public SolidColorBrush lightgreen100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DCEDC8"));

        public string lightgreen200string = "#C5E1A5";
        public string lightgreen200lightstring = "#F8FFD7";
        public string lightgreen200darkstring = "#94AF76";
        public SolidColorBrush lightgreen200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C5E1A5"));

        public string lightgreen300string = "#AED581";
        public string lightgreen300lightstring = "#E1FFB1";
        public string lightgreen300darkstring = "#7DA453";
        public SolidColorBrush lightgreen300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#AED581"));

        public string lightgreen400string = "#9CCC65";
        public string lightgreen400lightstring = "#CFFF95";
        public string lightgreen400darkstring = "#6B9B37";
        public SolidColorBrush lightgreen400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9CCC65"));

        public string lightgreen500string = "#8BC34A";
        public string lightgreen500lightstring = "#BEF67A";
        public string lightgreen500darkstring = "#5A9216";
        public SolidColorBrush lightgreen500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8BC34A"));

        public string lightgreen600string = "#7CB342";
        public string lightgreen600lightstring = "#AEE571";
        public string lightgreen600darkstring = "#4B830D";
        public SolidColorBrush lightgreen600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7CB342"));

        public string lightgreen700string = "#689F38";
        public string lightgreen700lightstring = "#99D066";
        public string lightgreen700darkstring = "#387002";
        public SolidColorBrush lightgreen700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#689F38"));

        public string lightgreen800string = "#558B2F";
        public string lightgreen800lightstring = "#85BB5C";
        public string lightgreen800darkstring = "#255D00";
        public SolidColorBrush lightgreen800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#558B2F"));

        public string lightgreen900string = "#33691E";
        public string lightgreen900lightstring = "#629749";
        public string lightgreen900darkstring = "#003D00";
        public SolidColorBrush lightgreen900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33691E"));

        public string lightgreena100string = "#CCFF90";
        public string lightgreena100lightstring = "#FFFFC2";
        public string lightgreena100darkstring = "#99CC60";
        public SolidColorBrush lightgreena100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CCFF90"));

        public string lightgreena200string = "#B2FF59";
        public string lightgreena200lightstring = "#E7FF8C";
        public string lightgreena200darkstring = "#7ECB20";
        public SolidColorBrush lightgreena200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B2FF59"));

        public string lightgreena400string = "#76FF03";
        public string lightgreena400lightstring = "#B0FF57";
        public string lightgreena400darkstring = "#32CB00";
        public SolidColorBrush lightgreena400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#76FF03"));

        public string lightgreena700string = "#64DD17";
        public string lightgreena700lightstring = "#9CFF57";
        public string lightgreena700darkstring = "#1FAA00";
        public SolidColorBrush lightgreena700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#64DD17"));

        public string lime50string = "#F9FBE7";
        public string lime50lightstring = "#FFFFFF";
        public string lime50darkstring = "#C6C8B5";
        public SolidColorBrush lime50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F9FBE7"));

        public string lime100string = "#F0F4C3";
        public string lime100lightstring = "#FFFFF6";
        public string lime100darkstring = "#BDC192";
        public SolidColorBrush lime100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F0F4C3"));

        public string lime200string = "#E6EE9C";
        public string lime200lightstring = "#FFFFCE";
        public string lime200darkstring = "#B3BC6D";
        public SolidColorBrush lime200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E6EE9C"));

        public string lime300string = "#DCE775";
        public string lime300lightstring = "#FFFFA6";
        public string lime300darkstring = "#A8B545";
        public SolidColorBrush lime300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DCE775"));

        public string lime400string = "#D4E157";
        public string lime400lightstring = "#FFFF89";
        public string lime400darkstring = "#A0AF22";
        public SolidColorBrush lime400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D4E157"));

        public string lime500string = "#CDDC39";
        public string lime500lightstring = "#FFFF6E";
        public string lime500darkstring = "#99AA00";
        public SolidColorBrush lime500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CDDC39"));

        public string lime600string = "#C0CA33";
        public string lime600lightstring = "#F5FD67";
        public string lime600darkstring = "#8C9900";
        public SolidColorBrush lime600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C0CA33"));

        public string lime700string = "#AFB42B";
        public string lime700lightstring = "#E4E65E";
        public string lime700darkstring = "#7C8500";
        public SolidColorBrush lime700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#AFB42B"));

        public string lime800string = "#9E9D24";
        public string lime800lightstring = "#D2CE56";
        public string lime800darkstring = "#6C6F00";
        public SolidColorBrush lime800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9E9D24"));

        public string lime900string = "#827717";
        public string lime900lightstring = "#B4A647";
        public string lime900darkstring = "#524C00";
        public SolidColorBrush lime900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#827717"));

        public string limea100string = "#F4FF81";
        public string limea100lightstring = "#FFFFB3";
        public string limea100darkstring = "#BFCC50";
        public SolidColorBrush limea100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F4FF81"));

        public string limea200string = "#EEFF41";
        public string limea200lightstring = "#FFFF78";
        public string limea200darkstring = "#B8CC00";
        public SolidColorBrush limea200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEFF41"));

        public string limea400string = "#C6FF00";
        public string limea400lightstring = "#FDFF58";
        public string limea400darkstring = "#90CC00";
        public SolidColorBrush limea400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C6FF00"));

        public string limea700string = "#AEEA00";
        public string limea700lightstring = "#E4FF54";
        public string limea700darkstring = "#79B700";
        public SolidColorBrush limea700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#AEEA00"));

        public string yellow50string = "#FFFDE9";
        public string yellow50lightstring = "#FFFFFF";
        public string yellow50darkstring = "#CCCAB5";
        public SolidColorBrush yellow50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFDE9"));

        public string yellow100string = "#FFF9C4";
        public string yellow100lightstring = "#FFFFF7";
        public string yellow100darkstring = "#CBC693";
        public SolidColorBrush yellow100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF9C4"));

        public string yellow200string = "#FFF59D";
        public string yellow200lightstring = "#FFFFCF";
        public string yellow200darkstring = "#CBC26D";
        public SolidColorBrush yellow200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF59D"));

        public string yellow300string = "#FFF176";
        public string yellow300lightstring = "#FFFFA8";
        public string yellow300darkstring = "#CABF45";
        public SolidColorBrush yellow300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF176"));

        public string yellow400string = "#FFEE58";
        public string yellow400lightstring = "#FFFF8B";
        public string yellow400darkstring = "#C9BC1F";
        public SolidColorBrush yellow400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFEE58"));

        public string yellow500string = "#FFEB3B";
        public string yellow500lightstring = "#FFFF72";
        public string yellow500darkstring = "#C8B900";
        public SolidColorBrush yellow500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFEB3B"));

        public string yellow600string = "#FDD835";
        public string yellow600lightstring = "#FFFF6B";
        public string yellow600darkstring = "#C6A700";
        public SolidColorBrush yellow600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FDD835"));

        public string yellow700string = "#FBC02D";
        public string yellow700lightstring = "#FFF263";
        public string yellow700darkstring = "#C49000";
        public SolidColorBrush yellow700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FBC02D"));

        public string yellow800string = "#F9A825";
        public string yellow800lightstring = "#FFD95A";
        public string yellow800darkstring = "#C17900";
        public SolidColorBrush yellow800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F9A825"));

        public string yellow900string = "#F57F17";
        public string yellow900lightstring = "#FFB04C";
        public string yellow900darkstring = "#BC5100";
        public SolidColorBrush yellow900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F57F17"));

        public string yellowa100string = "#FFFF8D";
        public string yellowa100lightstring = "#FFFFBF";
        public string yellowa100darkstring = "#CACC5D";
        public SolidColorBrush yellowa100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF8D"));

        public string yellowa200string = "#FFFF00";
        public string yellowa200lightstring = "#FFFF5A";
        public string yellowa200darkstring = "#C7CC00";
        public SolidColorBrush yellowa200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF00"));

        public string yellowa400string = "#FFEA00";
        public string yellowa400lightstring = "#FFFF56";
        public string yellowa400darkstring = "#C7B800";
        public SolidColorBrush yellowa400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFEA00"));

        public string yellowa700string = "#FFD600";
        public string yellowa700lightstring = "#FFFF52";
        public string yellowa700darkstring = "#C7A500";
        public SolidColorBrush yellowa700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD600"));

        public string amber50string = "#FFF8E1";
        public string amber50lightstring = "#FFFFFF";
        public string amber50darkstring = "#CCC5AF";
        public SolidColorBrush amber50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF8E1"));

        public string amber100string = "#FFECB3";
        public string amber100lightstring = "#FFFFE5";
        public string amber100darkstring = "#CBBA83";
        public SolidColorBrush amber100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFECB3"));

        public string amber200string = "#FFE082";
        public string amber200lightstring = "#FFFFB3";
        public string amber200darkstring = "#CAAE53";
        public SolidColorBrush amber200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE082"));

        public string amber300string = "#FFD54F";
        public string amber300lightstring = "#FFFF81";
        public string amber300darkstring = "#C8A415";
        public SolidColorBrush amber300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD54F"));

        public string amber400string = "#FFCA28";
        public string amber400lightstring = "#FFFD61";
        public string amber400darkstring = "#C79A00";
        public SolidColorBrush amber400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFCA28"));

        public string amber500string = "#FFC107";
        public string amber500lightstring = "#FFF350";
        public string amber500darkstring = "#C79100";
        public SolidColorBrush amber500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC107"));

        public string amber600string = "#FFB300";
        public string amber600lightstring = "#FFE54C";
        public string amber600darkstring = "#C68400";
        public SolidColorBrush amber600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB300"));

        public string amber700string = "#FFA000";
        public string amber700lightstring = "#FFD149";
        public string amber700darkstring = "#C67100";
        public SolidColorBrush amber700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFA000"));

        public string amber800string = "#FF8F00";
        public string amber800lightstring = "#FFC046";
        public string amber800darkstring = "#C56000";
        public SolidColorBrush amber800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF8F00"));

        public string amber900string = "#FF6F00";
        public string amber900lightstring = "#FFA040";
        public string amber900darkstring = "#C43E00";
        public SolidColorBrush amber900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF6F00"));

        public string ambera100string = "#FFE57F";
        public string ambera100lightstring = "#FFFFB0";
        public string ambera100darkstring = "#CAB350";
        public SolidColorBrush ambera100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE57F"));

        public string ambera200string = "#FFD740";
        public string ambera200lightstring = "#FFFF74";
        public string ambera200darkstring = "#C8A600";
        public SolidColorBrush ambera200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD740"));

        public string ambera400string = "#FFC400";
        public string ambera400lightstring = "#FFF64F";
        public string ambera400darkstring = "#C79400";
        public SolidColorBrush ambera400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC400"));

        public string ambera700string = "#FFAB00";
        public string ambera700lightstring = "#FFDD4B";
        public string ambera700darkstring = "#C67C00";
        public SolidColorBrush ambera700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFAB00"));

        public string orange50string = "#FFF3E0";
        public string orange50lightstring = "#FFFFFF";
        public string orange50darkstring = "#CCC0AE";
        public SolidColorBrush orange50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF3E0"));

        public string orange100string = "#FFE0B2";
        public string orange100lightstring = "#FFFFE4";
        public string orange100darkstring = "#CBAE82";
        public SolidColorBrush orange100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE0B2"));

        public string orange200string = "#FFCC80";
        public string orange200lightstring = "#FFFFB0";
        public string orange200darkstring = "#CA9B52";
        public SolidColorBrush orange200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFCC80"));

        public string orange300string = "#FFB74D";
        public string orange300lightstring = "#FFE97D";
        public string orange300darkstring = "#C88719";
        public SolidColorBrush orange300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB74D"));

        public string orange400string = "#FFA726";
        public string orange400lightstring = "#FFD95B";
        public string orange400darkstring = "#C77800";
        public SolidColorBrush orange400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFA726"));

        public string orange500string = "#FF9800";
        public string orange500lightstring = "#FFC947";
        public string orange500darkstring = "#C66900";
        public SolidColorBrush orange500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9800"));

        public string orange600string = "#FB8C00";
        public string orange600lightstring = "#FFBD45";
        public string orange600darkstring = "#C25E00";
        public SolidColorBrush orange600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FB8C00"));

        public string orange700string = "#F57C00";
        public string orange700lightstring = "#FFAD42";
        public string orange700darkstring = "#BB4D00";
        public SolidColorBrush orange700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F57C00"));

        public string orange800string = "#EF6C00";
        public string orange800lightstring = "#FF9D3F";
        public string orange800darkstring = "#B53D00";
        public SolidColorBrush orange800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EF6C00"));

        public string orange900string = "#E65100";
        public string orange900lightstring = "#FF833A";
        public string orange900darkstring = "#AC1900";
        public SolidColorBrush orange900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E65100"));

        public string orangea100string = "#FFD180";
        public string orangea100lightstring = "#FFFFB1";
        public string orangea100darkstring = "#CAA052";
        public SolidColorBrush orangea100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD180"));

        public string orangea200string = "#FFAB40";
        public string orangea200lightstring = "#FFDD71";
        public string orangea200darkstring = "#C77C02";
        public SolidColorBrush orangea200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFAB40"));

        public string orangea400string = "#FF9100";
        public string orangea400lightstring = "#FFC246";
        public string orangea400darkstring = "#C56200";
        public SolidColorBrush orangea400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9100"));

        public string orangea700string = "#FF6D00";
        public string orangea700lightstring = "#FF9E40";
        public string orangea700darkstring = "#C43C00";
        public SolidColorBrush orangea700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF6D00"));

        public string deeporange50string = "#FBE9E7";
        public string deeporange50lightstring = "#FFFFFF";
        public string deeporange50darkstring = "#C8B7B5";
        public SolidColorBrush deeporange50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FBE9E7"));

        public string deeporange100string = "#FFCCBC";
        public string deeporange100lightstring = "#FFFFEE";
        public string deeporange100darkstring = "#CB9B8C";
        public SolidColorBrush deeporange100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFCCBC"));

        public string deeporange200string = "#FFAB91";
        public string deeporange200lightstring = "#FFDDC1";
        public string deeporange200darkstring = "#C97B63";
        public SolidColorBrush deeporange200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFAB91"));

        public string deeporange300string = "#FF8A65";
        public string deeporange300lightstring = "#FFBB93";
        public string deeporange300darkstring = "#C75B39";
        public SolidColorBrush deeporange300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF8A65"));

        public string deeporange400string = "#FF8043";
        public string deeporange400lightstring = "#FFA270";
        public string deeporange400darkstring = "#C63F17";
        public SolidColorBrush deeporange400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7043"));

        public string deeporange500string = "#FF5722";
        public string deeporange500lightstring = "#FF8A50";
        public string deeporange500darkstring = "#C41C00";
        public SolidColorBrush deeporange500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5722"));

        public string deeporange600string = "#F4511E";
        public string deeporange600lightstring = "#FF844C";
        public string deeporange600darkstring = "#B91400";
        public SolidColorBrush deeporange600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F4511E"));

        public string deeporange700string = "#E64A19";
        public string deeporange700lightstring = "#FF7D47";
        public string deeporange700darkstring = "#AC0800";
        public SolidColorBrush deeporange700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E64A19"));

        public string deeporange800string = "#D84315";
        public string deeporange800lightstring = "#FF7543";
        public string deeporange800darkstring = "#9F0000";
        public SolidColorBrush deeporange800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D84315"));

        public string deeporange900string = "#BD360C";
        public string deeporange900lightstring = "#F9683A";
        public string deeporange900darkstring = "#870000";
        public SolidColorBrush deeporange900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BF360C"));

        public string deeporangea100string = "#FF9E80";
        public string deeporangea100lightstring = "#FFD0B0";
        public string deeporangea100darkstring = "#C96F53";
        public SolidColorBrush deeporangea100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9E80"));

        public string deeporangea200string = "#FF6E40";
        public string deeporangea200lightstring = "#FFA06D";
        public string deeporangea200darkstring = "#C53D13";
        public SolidColorBrush deeporangea200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF6E40"));

        public string deeporangea400string = "#FF3D00";
        public string deeporangea400lightstring = "#FF7539";
        public string deeporangea400darkstring = "#C30000";
        public SolidColorBrush deeporangea400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF3D00"));

        public string deeporangea700string = "#DD2C00";
        public string deeporangea700lightstring = "#FF6434";
        public string deeporangea700darkstring = "#A30000";
        public SolidColorBrush deeporangea700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DD2C00"));

        public string brown50string = "#EFEBE9";
        public string brown50lightstring = "#FFFFFF";
        public string brown50darkstring = "#BDB9B7";
        public SolidColorBrush brown50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFEBE9"));

        public string brown100string = "#D7CCC8";
        public string brown100lightstring = "#FFFFFB";
        public string brown100darkstring = "#A69B97";
        public SolidColorBrush brown100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A69B97"));

        public string brown200string = "#BCAAA4";
        public string brown200lightstring = "#EFDCD5";
        public string brown200darkstring = "#8C7B75";
        public SolidColorBrush brown200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BCAAA4"));

        public string brown300string = "#A1887F";
        public string brown300lightstring = "#D3B8AE";
        public string brown300darkstring = "#725B53";
        public SolidColorBrush brown300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A1887F"));

        public string brown400string = "#8D6E63";
        public string brown400lightstring = "#BE9C91";
        public string brown400darkstring = "#5F4339";
        public SolidColorBrush brown400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8D6E63"));

        public string brown500string = "#795548";
        public string brown500lightstring = "#A98274";
        public string brown500darkstring = "#4B2C20";
        public SolidColorBrush brown500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#795548"));

        public string brown600string = "#6D4C41";
        public string brown600lightstring = "#9C786C";
        public string brown600darkstring = "#40241A";
        public SolidColorBrush brown600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6D4C41"));

        public string brown700string = "#5D4037";
        public string brown700lightstring = "#8B6B61";
        public string brown700darkstring = "#321911";
        public SolidColorBrush brown700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5D4037"));

        public string brown800string = "#4E342E";
        public string brown800lightstring = "#7B5E57";
        public string brown800darkstring = "#260E04";
        public SolidColorBrush brown800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4E342E"));

        public string brown900string = "#3E2723";
        public string brown900lightstring = "#6A4F4B";
        public string brown900darkstring = "#1B0000";
        public SolidColorBrush brown900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3E2723"));

        public string grey50string = "#FAFAFA";
        public string grey50lightstring = "#FFFFFF";
        public string grey50darkstring = "#C7C7C7";
        public SolidColorBrush grey50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FAFAFA"));

        public string grey100string = "#F5F5F5";
        public string grey100lightstring = "#FFFFFF";
        public string grey100darkstring = "#C2C2C2";
        public SolidColorBrush grey100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F5F5F5"));

        public string grey200string = "#EEEEEE";
        public string grey200lightstring = "#FFFFFF";
        public string grey200darkstring = "#BCBCBC";
        public SolidColorBrush grey200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));

        public string grey300string = "#E0E0E0";
        public string grey300lightstring = "#FFFFFF";
        public string grey300darkstring = "#AEAEAE";
        public SolidColorBrush grey300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E0E0E0"));

        public string grey400string = "#BDBDBD";
        public string grey400lightstring = "#EFEFEF";
        public string grey400darkstring = "#8D8D8D";
        public SolidColorBrush grey400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DBDBDB"));

        public string grey500string = "#9E9E9E";
        public string grey500lightstring = "#CFCFCF";
        public string grey500darkstring = "#707070";
        public SolidColorBrush grey500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9E9E9E"));

        public string grey600string = "#757575";
        public string grey600lightstring = "#A4A4A4";
        public string grey600darkstring = "#494949";
        public SolidColorBrush grey600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#757575"));

        public string grey700string = "#616161";
        public string grey700lightstring = "#8E8E8E";
        public string grey700darkstring = "#373737";
        public SolidColorBrush grey700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#616161"));

        public string grey800string = "#424242";
        public string grey800lightstring = "#6D6D6D";
        public string grey800darkstring = "#1B1B1B";
        public SolidColorBrush grey800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#424242"));

        public string grey900string = "#212121";
        public string grey900lightstring = "#484848";
        public string grey900darkstring = "#000000";
        public SolidColorBrush grey900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#212121"));

        public string bluegrey50string = "#ECEFF1";
        public string bluegrey50lightstring = "#FFFFFF";
        public string bluegrey50darkstring = "#BABDBE";
        public SolidColorBrush bluegrey50brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ECEFF1"));

        public string bluegrey100string = "#CFD8DC";
        public string bluegrey100lightstring = "#FFFFFF";
        public string bluegrey100darkstring = "#9EA7AA";
        public SolidColorBrush bluegrey100brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CFD8DC"));

        public string bluegrey200string = "#B0BEC5";
        public string bluegrey200lightstring = "#E2F1F8";
        public string bluegrey200darkstring = "#808E95";
        public SolidColorBrush bluegrey200brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B0BEC5"));

        public string bluegrey300string = "#90A4AE";
        public string bluegrey300lightstring = "#C1D5E0";
        public string bluegrey300darkstring = "#62757F";
        public SolidColorBrush bluegrey300brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#90A4AE"));

        public string bluegrey400string = "#78909C";
        public string bluegrey400lightstring = "#A7C0CD";
        public string bluegrey400darkstring = "#4B636E";
        public SolidColorBrush bluegrey400brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#78909C"));

        public string bluegrey500string = "#607D8B";
        public string bluegrey500lightstring = "#8EACBB";
        public string bluegrey500darkstring = "#34515E";
        public SolidColorBrush bluegrey500brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#607D8B"));

        public string bluegrey600string = "#546E7A";
        public string bluegrey600lightstring = "#819CA9";
        public string bluegrey600darkstring = "#29434E";
        public SolidColorBrush bluegrey600brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#546E7A"));

        public string bluegrey700string = "#455A64";
        public string bluegrey700lightstring = "#718792";
        public string bluegrey700darkstring = "#1C313A";
        public SolidColorBrush bluegrey700brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#455A64"));

        public string bluegrey800string = "#37474F";
        public string bluegrey800lightstring = "#62727B";
        public string bluegrey800darkstring = "#102027";
        public SolidColorBrush bluegrey800brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#37474F"));

        public string bluegrey900string = "#263238";
        public string bluegrey900lightstring = "#4F5B62";
        public string bluegrey900darkstring = "#000A12";
        public SolidColorBrush bluegrey900brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#263238"));

        private void updateButtonColors()
        {
            red50.Fill = red50brush;
            red100.Fill = red100brush;
            red200.Fill = red200brush;
            red300.Fill = red300brush;
            red400.Fill = red400brush;
            red500.Fill = red500brush;
            red600.Fill = red600brush;
            red700.Fill = red700brush;
            red800.Fill = red800brush;
            red900.Fill = red900brush;
            reda100.Fill = reda100brush;
            reda200.Fill = reda200brush;
            reda400.Fill = reda400brush;
            reda700.Fill = reda700brush;

            pink50.Fill = pink50brush;
            pink100.Fill = pink100brush;
            pink200.Fill = pink200brush;
            pink300.Fill = pink300brush;
            pink400.Fill = pink400brush;
            pink500.Fill = pink500brush;
            pink600.Fill = pink600brush;
            pink700.Fill = pink700brush;
            pink800.Fill = pink800brush;
            pink900.Fill = pink900brush;
            pinka100.Fill = pinka100brush;
            pinka200.Fill = pinka200brush;
            pinka400.Fill = pinka400brush;
            pinka700.Fill = pinka700brush;

            purple50.Fill = purple50brush;
            purple100.Fill = purple100brush;
            purple200.Fill = purple200brush;
            purple300.Fill = purple300brush;
            purple400.Fill = purple400brush;
            purple500.Fill = purple500brush;
            purple600.Fill = purple600brush;
            purple700.Fill = purple700brush;
            purple800.Fill = purple800brush;
            purple900.Fill = purple900brush;
            purplea100.Fill = purplea100brush;
            purplea200.Fill = purplea200brush;
            purplea400.Fill = purplea400brush;
            purplea700.Fill = purplea700brush;

            deeppurple50.Fill = deeppurple50brush;
            deeppurple100.Fill = deeppurple100brush;
            deeppurple200.Fill = deeppurple200brush;
            deeppurple300.Fill = deeppurple300brush;
            deeppurple400.Fill = deeppurple400brush;
            deeppurple500.Fill = deeppurple500brush;
            deeppurple600.Fill = deeppurple600brush;
            deeppurple700.Fill = deeppurple700brush;
            deeppurple800.Fill = deeppurple800brush;
            deeppurple900.Fill = deeppurple900brush;
            deeppurplea100.Fill = deeppurplea100brush;
            deeppurplea200.Fill = deeppurplea200brush;
            deeppurplea400.Fill = deeppurplea400brush;
            deeppurplea700.Fill = deeppurplea700brush;

            indigo50.Fill = indigo50brush;
            indigo100.Fill = indigo100brush;
            indigo200.Fill = indigo200brush;
            indigo300.Fill = indigo300brush;
            indigo400.Fill = indigo400brush;
            indigo500.Fill = indigo500brush;
            indigo600.Fill = indigo600brush;
            indigo700.Fill = indigo700brush;
            indigo800.Fill = indigo800brush;
            indigo900.Fill = indigo900brush;
            indigoa100.Fill = indigoa100brush;
            indigoa200.Fill = indigoa200brush;
            indigoa400.Fill = indigoa400brush;
            indigoa700.Fill = indigoa700brush;

            blue50.Fill = blue50brush;
            blue100.Fill = blue100brush;
            blue200.Fill = blue200brush;
            blue300.Fill = blue300brush;
            blue400.Fill = blue400brush;
            blue500.Fill = blue500brush;
            blue600.Fill = blue600brush;
            blue700.Fill = blue700brush;
            blue800.Fill = blue800brush;
            blue900.Fill = blue900brush;
            bluea100.Fill = bluea100brush;
            bluea200.Fill = bluea200brush;
            bluea400.Fill = bluea400brush;
            bluea700.Fill = bluea700brush;

            lightblue50.Fill = lightblue50brush;
            lightblue100.Fill = lightblue100brush;
            lightblue200.Fill = lightblue200brush;
            lightblue300.Fill = lightblue300brush;
            lightblue400.Fill = lightblue400brush;
            lightblue500.Fill = lightblue500brush;
            lightblue600.Fill = lightblue600brush;
            lightblue700.Fill = lightblue700brush;
            lightblue800.Fill = lightblue800brush;
            lightblue900.Fill = lightblue900brush;
            lightbluea100.Fill = lightbluea100brush;
            lightbluea200.Fill = lightbluea200brush;
            lightbluea400.Fill = lightbluea400brush;
            lightbluea700.Fill = lightbluea700brush;

            cyan50.Fill = cyan50brush;
            cyan100.Fill = cyan100brush;
            cyan200.Fill = cyan200brush;
            cyan300.Fill = cyan300brush;
            cyan400.Fill = cyan400brush;
            cyan500.Fill = cyan500brush;
            cyan600.Fill = cyan600brush;
            cyan700.Fill = cyan700brush;
            cyan800.Fill = cyan800brush;
            cyan900.Fill = cyan900brush;
            cyana100.Fill = cyana100brush;
            cyana200.Fill = cyana200brush;
            cyana400.Fill = cyana400brush;
            cyana700.Fill = cyana700brush;

            teal50.Fill = teal50brush;
            teal100.Fill = teal100brush;
            teal200.Fill = teal200brush;
            teal300.Fill = teal300brush;
            teal400.Fill = teal400brush;
            teal500.Fill = teal500brush;
            teal600.Fill = teal600brush;
            teal700.Fill = teal700brush;
            teal800.Fill = teal800brush;
            teal900.Fill = teal900brush;
            teala100.Fill = teala100brush;
            teala200.Fill = teala200brush;
            teala400.Fill = teala400brush;
            teala700.Fill = teala700brush;

            green50.Fill = green50brush;
            green100.Fill = green100brush;
            green200.Fill = green200brush;
            green300.Fill = green300brush;
            green400.Fill = green400brush;
            green500.Fill = green500brush;
            green600.Fill = green600brush;
            green700.Fill = green700brush;
            green800.Fill = green800brush;
            green900.Fill = green900brush;
            greena100.Fill = greena100brush;
            greena200.Fill = greena200brush;
            greena400.Fill = greena400brush;
            greena700.Fill = greena700brush;

            lightgreen50.Fill = lightgreen50brush;
            lightgreen100.Fill = lightgreen100brush;
            lightgreen200.Fill = lightgreen200brush;
            lightgreen300.Fill = lightgreen300brush;
            lightgreen400.Fill = lightgreen400brush;
            lightgreen500.Fill = lightgreen500brush;
            lightgreen600.Fill = lightgreen600brush;
            lightgreen700.Fill = lightgreen700brush;
            lightgreen800.Fill = lightgreen800brush;
            lightgreen900.Fill = lightgreen900brush;
            lightgreena100.Fill = lightgreena100brush;
            lightgreena200.Fill = lightgreena200brush;
            lightgreena400.Fill = lightgreena400brush;
            lightgreena700.Fill = lightgreena700brush;

            lime50.Fill = lime50brush;
            lime100.Fill = lime100brush;
            lime200.Fill = lime200brush;
            lime300.Fill = lime300brush;
            lime400.Fill = lime400brush;
            lime500.Fill = lime500brush;
            lime600.Fill = lime600brush;
            lime700.Fill = lime700brush;
            lime800.Fill = lime800brush;
            lime900.Fill = lime900brush;
            limea100.Fill = limea100brush;
            limea200.Fill = limea200brush;
            limea400.Fill = limea400brush;
            limea700.Fill = limea700brush;

            yellow50.Fill = yellow50brush;
            yellow100.Fill = yellow100brush;
            yellow200.Fill = yellow200brush;
            yellow300.Fill = yellow300brush;
            yellow400.Fill = yellow400brush;
            yellow500.Fill = yellow500brush;
            yellow600.Fill = yellow600brush;
            yellow700.Fill = yellow700brush;
            yellow800.Fill = yellow800brush;
            yellow900.Fill = yellow900brush;
            yellowa100.Fill = yellowa100brush;
            yellowa200.Fill = yellowa200brush;
            yellowa400.Fill = yellowa400brush;
            yellowa700.Fill = yellowa700brush;

            amber50.Fill = amber50brush;
            amber100.Fill = amber100brush;
            amber200.Fill = amber200brush;
            amber300.Fill = amber300brush;
            amber400.Fill = amber400brush;
            amber500.Fill = amber500brush;
            amber600.Fill = amber600brush;
            amber700.Fill = amber700brush;
            amber800.Fill = amber800brush;
            amber900.Fill = amber900brush;
            ambera100.Fill = ambera100brush;
            ambera200.Fill = ambera200brush;
            ambera400.Fill = ambera400brush;
            ambera700.Fill = ambera700brush;

            orange50.Fill = orange50brush;
            orange100.Fill = orange100brush;
            orange200.Fill = orange200brush;
            orange300.Fill = orange300brush;
            orange400.Fill = orange400brush;
            orange500.Fill = orange500brush;
            orange600.Fill = orange600brush;
            orange700.Fill = orange700brush;
            orange800.Fill = orange800brush;
            orange900.Fill = orange900brush;
            orangea100.Fill = orangea100brush;
            orangea200.Fill = orangea200brush;
            orangea400.Fill = orangea400brush;
            orangea700.Fill = orangea700brush;

            deeporange50.Fill = deeporange50brush;
            deeporange100.Fill = deeporange100brush;
            deeporange200.Fill = deeporange200brush;
            deeporange300.Fill = deeporange300brush;
            deeporange400.Fill = deeporange400brush;
            deeporange500.Fill = deeporange500brush;
            deeporange600.Fill = deeporange600brush;
            deeporange700.Fill = deeporange700brush;
            deeporange800.Fill = deeporange800brush;
            deeporange900.Fill = deeporange900brush;
            deeporangea100.Fill = deeporangea100brush;
            deeporangea200.Fill = deeporangea200brush;
            deeporangea400.Fill = deeporangea400brush;
            deeporangea700.Fill = deeporangea700brush;

            brown50.Fill = brown50brush;
            brown100.Fill = brown100brush;
            brown200.Fill = brown200brush;
            brown300.Fill = brown300brush;
            brown400.Fill = brown400brush;
            brown500.Fill = brown500brush;
            brown600.Fill = brown600brush;
            brown700.Fill = brown700brush;
            brown800.Fill = brown800brush;
            brown900.Fill = brown900brush;

            grey50.Fill = grey50brush;
            grey100.Fill = grey100brush;
            grey200.Fill = grey200brush;
            grey300.Fill = grey300brush;
            grey400.Fill = grey400brush;
            grey500.Fill = grey500brush;
            grey600.Fill = grey600brush;
            grey700.Fill = grey700brush;
            grey800.Fill = grey800brush;
            grey900.Fill = grey900brush;

            bluegrey50.Fill = bluegrey50brush;
            bluegrey100.Fill = bluegrey100brush;
            bluegrey200.Fill = bluegrey200brush;
            bluegrey300.Fill = bluegrey300brush;
            bluegrey400.Fill = bluegrey400brush;
            bluegrey500.Fill = bluegrey500brush;
            bluegrey600.Fill = bluegrey600brush;
            bluegrey700.Fill = bluegrey700brush;
            bluegrey800.Fill = bluegrey800brush;
            bluegrey900.Fill = bluegrey900brush;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateButtonColors();
        }

        private void updatePreview()
        {
            if (primaryid == -1)
            {
                SolidColorBrush blackbrush = new SolidColorBrush(Colors.Black);
                previewTopBar.Fill = resetbrush;
                previewHeaderBar.Fill = resetbrush;
                previewBG1.Fill = resetbrush;
                previewMenuMarker.Fill = resetbrush;
                previewBG2.Fill = resetbrush;
                previewBG3.Fill = resetbrush;
                previewMenu1Text.Text = "";
                previewMenu2Text.Text = "";
                previewMenu3Text.Text = "";
                previewButton.Fill = resetbrush;
                previewButtonP1.Fill = resetbrush;
                previewButtonP2.Fill = resetbrush;
                showPrimary.Fill = resetbrush;
                showPrimaryText.Foreground = blackbrush;
                showPrimaryColor.Foreground = blackbrush;
                showPrimaryColor.Text = "";
                showPrimaryLight.Fill = resetbrush;
                showPrimaryLightText.Foreground = blackbrush;
                showPrimaryLightColor.Foreground = blackbrush;
                showPrimaryLightColor.Text = "";
                showPrimaryDark.Fill = resetbrush;
                showPrimaryDarkText.Foreground = blackbrush;
                showPrimaryDarkColor.Foreground = blackbrush;
                showPrimaryDarkColor.Text = "";
                primaryCursor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3F4349"));
                primaryCursor.SetValue(Grid.RowProperty, 0);
                primaryCursor.SetValue(Grid.ColumnProperty, 0);
            } else
            {
                SolidColorBrush primarybrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(primary));
                SolidColorBrush primarylightbrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(primarylight));
                SolidColorBrush primarydarkbrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(primarydark));
                SolidColorBrush textcolorbrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(textcolor));
                previewTopBar.Fill = primarydarkbrush;
                previewHeaderBar.Fill = primarybrush;
                previewBG1.Fill = primarylightbrush;
                previewMenuMarker.Fill = primarybrush;
                previewBG2.Fill = primarylightbrush;
                previewButton.Fill = primarybrush;
                previewMenu1Text.Foreground = textcolorbrush;
                previewMenu2Text.Foreground = textcolorbrush;
                previewMenu3Text.Foreground = textcolorbrush;
                previewButtonP1.Fill = textcolorbrush;
                previewButtonP2.Fill = textcolorbrush;
                showPrimary.Fill = primarybrush;
                showPrimaryText.Foreground = textcolorbrush;
                showPrimaryColor.Foreground = textcolorbrush;
                Color temp = (Color)ColorConverter.ConvertFromString(primary);
                showPrimaryColor.Text = primary + "\n" + "R:" + temp.R + " G:" + temp.G + " B:" + temp.B;
                showPrimaryLight.Fill = primarylightbrush;
                showPrimaryLightText.Foreground = textcolorbrush;
                showPrimaryLightColor.Foreground = textcolorbrush;
                temp = (Color)ColorConverter.ConvertFromString(primarylight);
                showPrimaryLightColor.Text = primarylight + "\n" + "R:" + temp.R + " G:" + temp.G + " B:" + temp.B;
                showPrimaryDark.Fill = primarydarkbrush;
                showPrimaryDarkText.Foreground = textcolorbrush;
                showPrimaryDarkColor.Foreground = textcolorbrush;
                temp = (Color)ColorConverter.ConvertFromString(primarydark);
                showPrimaryDarkColor.Text = primarydark + "\n" + "R:" + temp.R + " G:" + temp.G + " B:" + temp.B;
                primaryCursor.Foreground = textcolorbrush;
                if(primaryid <= 223)
                {
                    primaryCursor.SetValue(Grid.ColumnProperty, (primaryid%14) + 1);
                    primaryCursor.SetValue(Grid.RowProperty, (int)(primaryid / 14) + 2);
                } else
                {
                    int tempid = primaryid - 224;
                    primaryCursor.SetValue(Grid.ColumnProperty, (tempid % 10) + 1);
                    primaryCursor.SetValue(Grid.RowProperty, (int)(tempid / 10) + 18);
                }

                if(secondaryid != -1)
                {
                    SolidColorBrush secondarybrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondary));
                    SolidColorBrush secondarylightbrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondarylight));
                    SolidColorBrush secondarydarkbrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondarydark));
                    SolidColorBrush secondarytextcolorbrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondarytextcolor));

                    previewMenuMarker.Fill = secondarybrush;
                    previewButton.Fill = secondarybrush;
                    previewButtonP1.Fill = secondarytextcolorbrush;
                    previewButtonP2.Fill = secondarytextcolorbrush;

                    showSecondary.Fill = secondarybrush;
                    showSecondaryText.Foreground = textcolorbrush;
                    showSecondaryColor.Foreground = textcolorbrush;
                    Color temp2 = (Color)ColorConverter.ConvertFromString(secondary);
                    showSecondaryColor.Text = secondary + "\n" + "R:" + temp2.R + " G:" + temp2.G + " B:" + temp2.B;
                    showSecondaryLight.Fill = secondarylightbrush;
                    showSecondaryLightText.Foreground = textcolorbrush;
                    showSecondaryLightColor.Foreground = textcolorbrush;
                    temp2 = (Color)ColorConverter.ConvertFromString(secondarylight);
                    showSecondaryLightColor.Text = secondarylight + "\n" + "R:" + temp2.R + " G:" + temp2.G + " B:" + temp2.B;
                    showSecondaryDark.Fill = secondarydarkbrush;
                    showSecondaryDarkText.Foreground = textcolorbrush;
                    showSecondaryDarkColor.Foreground = textcolorbrush;
                    temp2 = (Color)ColorConverter.ConvertFromString(secondarydark);
                    showSecondaryDarkColor.Text = secondarydark + "\n" + "R:" + temp2.R + " G:" + temp2.G + " B:" + temp2.B;
                }

                previewMenu1Text.Text = "Tab 1";
                previewMenu2Text.Text = "Tab 2";
                previewMenu3Text.Text = "Tab 3";
                previewBG3.Fill = new SolidColorBrush(Colors.LightGray);
            }
            if(secondaryid != -1)
            {
                SolidColorBrush secondarybrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondary));
                SolidColorBrush secondarylightbrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondarylight));
                SolidColorBrush secondarydarkbrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondarydark));
                SolidColorBrush secondarytextcolorbrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondarytextcolor));

                showSecondary.Fill = secondarybrush;
                showSecondaryText.Foreground = secondarytextcolorbrush;
                showSecondaryColor.Foreground = secondarytextcolorbrush;
                Color temp2 = (Color)ColorConverter.ConvertFromString(secondary);
                showSecondaryColor.Text = secondary + "\n" + "R:" + temp2.R + " G:" + temp2.G + " B:" + temp2.B;
                showSecondaryLight.Fill = secondarylightbrush;
                showSecondaryLightText.Foreground = secondarytextcolorbrush;
                showSecondaryLightColor.Foreground = secondarytextcolorbrush;
                temp2 = (Color)ColorConverter.ConvertFromString(secondarylight);
                showSecondaryLightColor.Text = secondarylight + "\n" + "R:" + temp2.R + " G:" + temp2.G + " B:" + temp2.B;
                showSecondaryDark.Fill = secondarydarkbrush;
                showSecondaryDarkText.Foreground = secondarytextcolorbrush;
                showSecondaryDarkColor.Foreground = secondarytextcolorbrush;
                temp2 = (Color)ColorConverter.ConvertFromString(secondarydark);
                showSecondaryDarkColor.Text = secondarydark + "\n" + "R:" + temp2.R + " G:" + temp2.G + " B:" + temp2.B;
                secondaryCursor.Foreground = secondarytextcolorbrush;
                if (secondaryid <= 223)
                {
                    secondaryCursor.SetValue(Grid.ColumnProperty, (secondaryid % 14) + 1);
                    secondaryCursor.SetValue(Grid.RowProperty, (int)(secondaryid / 14) + 2);
                }
                else
                {
                    int tempid = secondaryid - 224;
                    secondaryCursor.SetValue(Grid.ColumnProperty, (tempid % 10) + 1);
                    secondaryCursor.SetValue(Grid.RowProperty, (int)(tempid / 10) + 18);
                }
            } else
            {
                SolidColorBrush blackbrush = new SolidColorBrush(Colors.Black);
                showSecondary.Fill = resetbrush;
                showSecondaryText.Foreground = blackbrush;
                showSecondaryColor.Foreground = blackbrush;
                showSecondaryColor.Text = "";
                showSecondaryLight.Fill = resetbrush;
                showSecondaryLightText.Foreground = blackbrush;
                showSecondaryLightColor.Foreground = blackbrush;
                showSecondaryLightColor.Text = "";
                showSecondaryDark.Fill = resetbrush;
                showSecondaryDarkText.Foreground = blackbrush;
                showSecondaryDarkColor.Foreground = blackbrush;
                showSecondaryDarkColor.Text = "";
                secondaryCursor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3F4349"));
                secondaryCursor.SetValue(Grid.RowProperty, 0);
                secondaryCursor.SetValue(Grid.ColumnProperty, 0);
            }
            if(secondaryid == primaryid)
            {
                secondaryCursor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3F4349"));
                secondaryCursor.SetValue(Grid.RowProperty, 0);
                secondaryCursor.SetValue(Grid.ColumnProperty, 0);
            }
        }

        private void ColorEnter(object sender, MouseEventArgs e)
        {
            Rectangle temp = (Rectangle)e.Source;
            Brush tempb = temp.Fill;
            Color tempc = (Color)ColorConverter.ConvertFromString(tempb.ToString());
            if (tempc.R <= 215)
                tempc.R += 40;
            else
                tempc.R = 255;
            if (tempc.G <= 215)
                tempc.G += 40;
            else
                tempc.G = 255;
            if (tempc.B <= 215)
                tempc.B += 40;
            else
                tempc.B = 255;
            temp.Fill = new SolidColorBrush(tempc);
        }

        private void ColorLeave(object sender, MouseEventArgs e)
        {
            Rectangle temp = (Rectangle)e.Source;
            Brush tempb = temp.Fill;
            Color tempc = (Color)ColorConverter.ConvertFromString(tempb.ToString());
            if(tempc.R == 255 || tempc.G == 255 || tempc.B == 255)
            {
                updateButtonColors();
            } else
            {
                if (tempc.R >= 40)
                    tempc.R -= 40;
                else
                    tempc.R = 255;
                if (tempc.G >= 40)
                    tempc.G -= 40;
                else
                    tempc.G = 255;
                if (tempc.B >= 40)
                    tempc.B -= 40;
                else
                    tempc.B = 255;
                temp.Fill = new SolidColorBrush(tempc);
            }

        }

        private void Red50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(primaryid != 0)
            {
                primaryid = 0;
                primary = red50string;
                primarylight = red50lightstring;
                primarydark = red50darkstring;
                textcolor = "#000000";
                updatePreview();
            } else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(secondaryid != 0)
            {
                secondaryid = 0;
                secondary = red50string;
                secondarylight = red50lightstring;
                secondarydark = red50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            } else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 1)
            {
                primaryid = 1;
                primary = red100string;
                primarylight = red100lightstring;
                primarydark = red100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 1)
            {
                secondaryid = 1;
                secondary = red100string;
                secondarylight = red100lightstring;
                secondarydark = red100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 2)
            {
                primaryid = 2;
                primary = red200string;
                primarylight = red200lightstring;
                primarydark = red200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 2)
            {
                secondaryid = 2;
                secondary = red200string;
                secondarylight = red200lightstring;
                secondarydark = red200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 3)
            {
                primaryid = 3;
                primary = red300string;
                primarylight = red300lightstring;
                primarydark = red300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 3)
            {
                secondaryid = 3;
                secondary = red300string;
                secondarylight = red300lightstring;
                secondarydark = red300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 4)
            {
                primaryid = 4;
                primary = red400string;
                primarylight = red400lightstring;
                primarydark = red400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 4)
            {
                secondaryid = 4;
                secondary = red400string;
                secondarylight = red400lightstring;
                secondarydark = red400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 5)
            {
                primaryid = 5;
                primary = red500string;
                primarylight = red500lightstring;
                primarydark = red500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 5)
            {
                secondaryid = 5;
                secondary = red500string;
                secondarylight = red500lightstring;
                secondarydark = red500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 6)
            {
                primaryid = 6;
                primary = red600string;
                primarylight = red600lightstring;
                primarydark = red600darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 6)
            {
                secondaryid = 6;
                secondary = red600string;
                secondarylight = red600lightstring;
                secondarydark = red600darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 7)
            {
                primaryid = 7;
                primary = red700string;
                primarylight = red700lightstring;
                primarydark = red700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 7)
            {
                secondaryid = 7;
                secondary = red700string;
                secondarylight = red700lightstring;
                secondarydark = red700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 8)
            {
                primaryid = 8;
                primary = red800string;
                primarylight = red800lightstring;
                primarydark = red800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 8)
            {
                secondaryid = 8;
                secondary = red800string;
                secondarylight = red800lightstring;
                secondarydark = red800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 9)
            {
                primaryid = 9;
                primary = red900string;
                primarylight = red900lightstring;
                primarydark = red900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Red900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 9)
            {
                secondaryid = 9;
                secondary = red900string;
                secondarylight = red900lightstring;
                secondarydark = red900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Reda100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 10)
            {
                primaryid = 10;
                primary = reda100string;
                primarylight = reda100lightstring;
                primarydark = reda100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Reda100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 10)
            {
                secondaryid = 10;
                secondary = reda100string;
                secondarylight = reda100lightstring;
                secondarydark = reda100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Reda200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 11)
            {
                primaryid = 11;
                primary = reda200string;
                primarylight = reda200lightstring;
                primarydark = reda200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Reda200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 11)
            {
                secondaryid = 11;
                secondary = reda200string;
                secondarylight = reda200lightstring;
                secondarydark = reda200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Reda400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 12)
            {
                primaryid = 12;
                primary = reda400string;
                primarylight = reda400lightstring;
                primarydark = reda400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Reda400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 12)
            {
                secondaryid = 12;
                secondary = reda400string;
                secondarylight = reda400lightstring;
                secondarydark = reda400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Reda700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 13)
            {
                primaryid = 13;
                primary = reda700string;
                primarylight = reda700lightstring;
                primarydark = reda700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Reda700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 13)
            {
                secondaryid = 13;
                secondary = reda700string;
                secondarylight = reda700lightstring;
                secondarydark = reda700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 14)
            {
                primaryid = 14;
                primary = pink50string;
                primarylight = pink50lightstring;
                primarydark = pink50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 14)
            {
                secondaryid = 14;
                secondary = pink50string;
                secondarylight = pink50lightstring;
                secondarydark = pink50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 15)
            {
                primaryid = 15;
                primary = pink100string;
                primarylight = pink100lightstring;
                primarydark = pink100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 15)
            {
                secondaryid = 15;
                secondary = pink100string;
                secondarylight = pink100lightstring;
                secondarydark = pink100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 16)
            {
                primaryid = 16;
                primary = pink200string;
                primarylight = pink200lightstring;
                primarydark = pink200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 16)
            {
                secondaryid = 16;
                secondary = pink200string;
                secondarylight = pink200lightstring;
                secondarydark = pink200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 17)
            {
                primaryid = 17;
                primary = pink300string;
                primarylight = pink300lightstring;
                primarydark = pink300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 17)
            {
                secondaryid = 17;
                secondary = pink300string;
                secondarylight = pink300lightstring;
                secondarydark = pink300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 18)
            {
                primaryid = 18;
                primary = pink400string;
                primarylight = pink400lightstring;
                primarydark = pink400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 18)
            {
                secondaryid = 18;
                secondary = pink400string;
                secondarylight = pink400lightstring;
                secondarydark = pink400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 19)
            {
                primaryid = 19;
                primary = pink500string;
                primarylight = pink500lightstring;
                primarydark = pink500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 19)
            {
                secondaryid = 19;
                secondary = pink500string;
                secondarylight = pink500lightstring;
                secondarydark = pink500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 20)
            {
                primaryid = 20;
                primary = pink600string;
                primarylight = pink600lightstring;
                primarydark = pink600darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 20)
            {
                secondaryid = 20;
                secondary = pink600string;
                secondarylight = pink600lightstring;
                secondarydark = pink600darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 21)
            {
                primaryid = 21;
                primary = pink700string;
                primarylight = pink700lightstring;
                primarydark = pink700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 21)
            {
                secondaryid = 21;
                secondary = pink700string;
                secondarylight = pink700lightstring;
                secondarydark = pink700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 22)
            {
                primaryid = 22;
                primary = pink800string;
                primarylight = pink800lightstring;
                primarydark = pink800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 22)
            {
                secondaryid = 22;
                secondary = pink800string;
                secondarylight = pink800lightstring;
                secondarydark = pink800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 23)
            {
                primaryid = 23;
                primary = pink900string;
                primarylight = pink900lightstring;
                primarydark = pink900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pink900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 23)
            {
                secondaryid = 23;
                secondary = pink900string;
                secondarylight = pink900lightstring;
                secondarydark = pink900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pinka100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 24)
            {
                primaryid = 24;
                primary = pinka100string;
                primarylight = pinka100lightstring;
                primarydark = pinka100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pinka100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 24)
            {
                secondaryid = 24;
                secondary = pinka100string;
                secondarylight = pinka100lightstring;
                secondarydark = pinka100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pinka200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 25)
            {
                primaryid = 25;
                primary = pinka200string;
                primarylight = pinka200lightstring;
                primarydark = pinka200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pinka200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 25)
            {
                secondaryid = 25;
                secondary = pinka200string;
                secondarylight = pinka200lightstring;
                secondarydark = pinka200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pinka400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 26)
            {
                primaryid = 26;
                primary = pinka400string;
                primarylight = pinka400lightstring;
                primarydark = pinka400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pinka400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 26)
            {
                secondaryid = 26;
                secondary = pinka400string;
                secondarylight = pinka400lightstring;
                secondarydark = pinka400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pinka700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 27)
            {
                primaryid = 27;
                primary = pinka700string;
                primarylight = pinka700lightstring;
                primarydark = pinka700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Pinka700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 27)
            {
                secondaryid = 27;
                secondary = pinka700string;
                secondarylight = pinka700lightstring;
                secondarydark = pinka700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 28)
            {
                primaryid = 28;
                primary = purple50string;
                primarylight = purple50lightstring;
                primarydark = purple50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 28)
            {
                secondaryid = 28;
                secondary = purple50string;
                secondarylight = purple50lightstring;
                secondarydark = purple50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 29)
            {
                primaryid = 29;
                primary = purple100string;
                primarylight = purple100lightstring;
                primarydark = purple100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 29)
            {
                secondaryid = 29;
                secondary = purple100string;
                secondarylight = purple100lightstring;
                secondarydark = purple100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 30)
            {
                primaryid = 30;
                primary = purple200string;
                primarylight = purple200lightstring;
                primarydark = purple200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 30)
            {
                secondaryid = 30;
                secondary = purple200string;
                secondarylight = purple200lightstring;
                secondarydark = purple200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 31)
            {
                primaryid = 31;
                primary = purple300string;
                primarylight = purple300lightstring;
                primarydark = purple300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 31)
            {
                secondaryid = 31;
                secondary = purple300string;
                secondarylight = purple300lightstring;
                secondarydark = purple300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 32)
            {
                primaryid = 32;
                primary = purple400string;
                primarylight = purple400lightstring;
                primarydark = purple400darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 32)
            {
                secondaryid = 32;
                secondary = purple400string;
                secondarylight = purple400lightstring;
                secondarydark = purple400darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 33)
            {
                primaryid = 33;
                primary = purple500string;
                primarylight = purple500lightstring;
                primarydark = purple500darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 33)
            {
                secondaryid = 33;
                secondary = purple500string;
                secondarylight = purple500lightstring;
                secondarydark = purple500darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 34)
            {
                primaryid = 34;
                primary = purple600string;
                primarylight = purple600lightstring;
                primarydark = purple600darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 34)
            {
                secondaryid = 34;
                secondary = purple600string;
                secondarylight = purple600lightstring;
                secondarydark = purple600darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 35)
            {
                primaryid = 35;
                primary = purple700string;
                primarylight = purple700lightstring;
                primarydark = purple700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 35)
            {
                secondaryid = 35;
                secondary = purple700string;
                secondarylight = purple700lightstring;
                secondarydark = purple700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 36)
            {
                primaryid = 36;
                primary = purple800string;
                primarylight = purple800lightstring;
                primarydark = purple800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 36)
            {
                secondaryid = 36;
                secondary = purple800string;
                secondarylight = purple800lightstring;
                secondarydark = purple800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 37)
            {
                primaryid = 37;
                primary = purple900string;
                primarylight = purple900lightstring;
                primarydark = purple900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purple900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 37)
            {
                secondaryid = 37;
                secondary = purple900string;
                secondarylight = purple900lightstring;
                secondarydark = purple900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purplea100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 38)
            {
                primaryid = 38;
                primary = purplea100string;
                primarylight = purplea100lightstring;
                primarydark = purplea100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purplea100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 38)
            {
                secondaryid = 38;
                secondary = purplea100string;
                secondarylight = purplea100lightstring;
                secondarydark = purplea100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purplea200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 39)
            {
                primaryid = 39;
                primary = purplea200string;
                primarylight = purplea200lightstring;
                primarydark = purplea200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purplea200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 39)
            {
                secondaryid = 39;
                secondary = purplea200string;
                secondarylight = purplea200lightstring;
                secondarydark = purplea200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purplea400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 40)
            {
                primaryid = 40;
                primary = purplea400string;
                primarylight = purplea400lightstring;
                primarydark = purplea400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purplea400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 40)
            {
                secondaryid = 40;
                secondary = purplea400string;
                secondarylight = purplea400lightstring;
                secondarydark = purplea400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purplea700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 41)
            {
                primaryid = 41;
                primary = purplea700string;
                primarylight = purplea700lightstring;
                primarydark = purplea700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Purplea700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 41)
            {
                secondaryid = 41;
                secondary = purplea700string;
                secondarylight = purplea700lightstring;
                secondarydark = purplea700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 42)
            {
                primaryid = 42;
                primary = deeppurple50string;
                primarylight = deeppurple50lightstring;
                primarydark = deeppurple50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 42)
            {
                secondaryid = 42;
                secondary = deeppurple50string;
                secondarylight = deeppurple50lightstring;
                secondarydark = deeppurple50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 43)
            {
                primaryid = 43;
                primary = deeppurple100string;
                primarylight = deeppurple100lightstring;
                primarydark = deeppurple100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 43)
            {
                secondaryid = 43;
                secondary = deeppurple100string;
                secondarylight = deeppurple100lightstring;
                secondarydark = deeppurple100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 44)
            {
                primaryid = 44;
                primary = deeppurple200string;
                primarylight = deeppurple200lightstring;
                primarydark = deeppurple200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 44)
            {
                secondaryid = 44;
                secondary = deeppurple200string;
                secondarylight = deeppurple200lightstring;
                secondarydark = deeppurple200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 45)
            {
                primaryid = 45;
                primary = deeppurple300string;
                primarylight = deeppurple300lightstring;
                primarydark = deeppurple300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 45)
            {
                secondaryid = 45;
                secondary = deeppurple300string;
                secondarylight = deeppurple300lightstring;
                secondarydark = deeppurple300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 46)
            {
                primaryid = 46;
                primary = deeppurple400string;
                primarylight = deeppurple400lightstring;
                primarydark = deeppurple400darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 46)
            {
                secondaryid = 46;
                secondary = deeppurple400string;
                secondarylight = deeppurple400lightstring;
                secondarydark = deeppurple400darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 47)
            {
                primaryid = 47;
                primary = deeppurple500string;
                primarylight = deeppurple500lightstring;
                primarydark = deeppurple500darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 47)
            {
                secondaryid = 47;
                secondary = deeppurple500string;
                secondarylight = deeppurple500lightstring;
                secondarydark = deeppurple500darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 48)
            {
                primaryid = 48;
                primary = deeppurple600string;
                primarylight = deeppurple600lightstring;
                primarydark = deeppurple600darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 48)
            {
                secondaryid = 48;
                secondary = deeppurple600string;
                secondarylight = deeppurple600lightstring;
                secondarydark = deeppurple600darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 49)
            {
                primaryid = 49;
                primary = deeppurple700string;
                primarylight = deeppurple700lightstring;
                primarydark = deeppurple700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 49)
            {
                secondaryid = 49;
                secondary = deeppurple700string;
                secondarylight = deeppurple700lightstring;
                secondarydark = deeppurple700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 50)
            {
                primaryid = 50;
                primary = deeppurple800string;
                primarylight = deeppurple800lightstring;
                primarydark = deeppurple800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 50)
            {
                secondaryid = 50;
                secondary = deeppurple800string;
                secondarylight = deeppurple800lightstring;
                secondarydark = deeppurple800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 51)
            {
                primaryid = 51;
                primary = deeppurple900string;
                primarylight = deeppurple900lightstring;
                primarydark = deeppurple900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurple900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 51)
            {
                secondaryid = 51;
                secondary = deeppurple900string;
                secondarylight = deeppurple900lightstring;
                secondarydark = deeppurple900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurplea100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 52)
            {
                primaryid = 52;
                primary = deeppurplea100string;
                primarylight = deeppurplea100lightstring;
                primarydark = deeppurplea100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurplea100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 52)
            {
                secondaryid = 52;
                secondary = deeppurplea100string;
                secondarylight = deeppurplea100lightstring;
                secondarydark = deeppurplea100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurplea200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 53)
            {
                primaryid = 53;
                primary = deeppurplea200string;
                primarylight = deeppurplea200lightstring;
                primarydark = deeppurplea200darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurplea200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 53)
            {
                secondaryid = 53;
                secondary = deeppurplea200string;
                secondarylight = deeppurplea200lightstring;
                secondarydark = deeppurplea200darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurplea400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 54)
            {
                primaryid = 54;
                primary = deeppurplea400string;
                primarylight = deeppurplea400lightstring;
                primarydark = deeppurplea400darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurplea400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 54)
            {
                secondaryid = 54;
                secondary = deeppurplea400string;
                secondarylight = deeppurplea400lightstring;
                secondarydark = deeppurplea400darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurplea700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 55)
            {
                primaryid = 55;
                primary = deeppurplea700string;
                primarylight = deeppurplea700lightstring;
                primarydark = deeppurplea700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeppurplea700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 55)
            {
                secondaryid = 55;
                secondary = deeppurplea700string;
                secondarylight = deeppurplea700lightstring;
                secondarydark = deeppurplea700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 56)
            {
                primaryid = 56;
                primary = indigo50string;
                primarylight = indigo50lightstring;
                primarydark = indigo50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 56)
            {
                secondaryid = 56;
                secondary = indigo50string;
                secondarylight = indigo50lightstring;
                secondarydark = indigo50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 57)
            {
                primaryid = 57;
                primary = indigo100string;
                primarylight = indigo100lightstring;
                primarydark = indigo100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 57)
            {
                secondaryid = 57;
                secondary = indigo100string;
                secondarylight = indigo100lightstring;
                secondarydark = indigo100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 58)
            {
                primaryid = 58;
                primary = indigo200string;
                primarylight = indigo200lightstring;
                primarydark = indigo200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 58)
            {
                secondaryid = 58;
                secondary = indigo200string;
                secondarylight = indigo200lightstring;
                secondarydark = indigo200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 59)
            {
                primaryid = 59;
                primary = indigo300string;
                primarylight = indigo300lightstring;
                primarydark = indigo300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 59)
            {
                secondaryid = 59;
                secondary = indigo300string;
                secondarylight = indigo300lightstring;
                secondarydark = indigo300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 60)
            {
                primaryid = 60;
                primary = indigo400string;
                primarylight = indigo400lightstring;
                primarydark = indigo400darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 60)
            {
                secondaryid = 60;
                secondary = indigo400string;
                secondarylight = indigo400lightstring;
                secondarydark = indigo400darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 61)
            {
                primaryid = 61;
                primary = indigo500string;
                primarylight = indigo500lightstring;
                primarydark = indigo500darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 61)
            {
                secondaryid = 61;
                secondary = indigo500string;
                secondarylight = indigo500lightstring;
                secondarydark = indigo500darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 62)
            {
                primaryid = 62;
                primary = indigo600string;
                primarylight = indigo600lightstring;
                primarydark = indigo600darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 62)
            {
                secondaryid = 62;
                secondary = indigo600string;
                secondarylight = indigo600lightstring;
                secondarydark = indigo600darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 63)
            {
                primaryid = 63;
                primary = indigo700string;
                primarylight = indigo700lightstring;
                primarydark = indigo700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 63)
            {
                secondaryid = 63;
                secondary = indigo700string;
                secondarylight = indigo700lightstring;
                secondarydark = indigo700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 64)
            {
                primaryid = 64;
                primary = indigo800string;
                primarylight = indigo800lightstring;
                primarydark = indigo800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 64)
            {
                secondaryid = 64;
                secondary = indigo800string;
                secondarylight = indigo800lightstring;
                secondarydark = indigo800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 65)
            {
                primaryid = 65;
                primary = indigo900string;
                primarylight = indigo900lightstring;
                primarydark = indigo900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigo900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 65)
            {
                secondaryid = 65;
                secondary = indigo900string;
                secondarylight = indigo900lightstring;
                secondarydark = indigo900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigoa100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 66)
            {
                primaryid = 66;
                primary = indigoa100string;
                primarylight = indigoa100lightstring;
                primarydark = indigoa100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigoa100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 66)
            {
                secondaryid = 66;
                secondary = indigoa100string;
                secondarylight = indigoa100lightstring;
                secondarydark = indigoa100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigoa200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 67)
            {
                primaryid = 67;
                primary = indigoa200string;
                primarylight = indigoa200lightstring;
                primarydark = indigoa200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigoa200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 67)
            {
                secondaryid = 67;
                secondary = indigoa200string;
                secondarylight = indigoa200lightstring;
                secondarydark = indigoa200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigoa400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 68)
            {
                primaryid = 68;
                primary = indigoa400string;
                primarylight = indigoa400lightstring;
                primarydark = indigoa400darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigoa400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 68)
            {
                secondaryid = 68;
                secondary = indigoa400string;
                secondarylight = indigoa400lightstring;
                secondarydark = indigoa400darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigoa700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 69)
            {
                primaryid = 69;
                primary = indigoa700string;
                primarylight = indigoa700lightstring;
                primarydark = indigoa700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Indigoa700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 69)
            {
                secondaryid = 69;
                secondary = indigoa700string;
                secondarylight = indigoa700lightstring;
                secondarydark = indigoa700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 70)
            {
                primaryid = 70;
                primary = blue50string;
                primarylight = blue50lightstring;
                primarydark = blue50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 70)
            {
                secondaryid = 70;
                secondary = blue50string;
                secondarylight = blue50lightstring;
                secondarydark = blue50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 71)
            {
                primaryid = 71;
                primary = blue100string;
                primarylight = blue100lightstring;
                primarydark = blue100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 71)
            {
                secondaryid = 71;
                secondary = blue100string;
                secondarylight = blue100lightstring;
                secondarydark = blue100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 72)
            {
                primaryid = 72;
                primary = blue200string;
                primarylight = blue200lightstring;
                primarydark = blue200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 72)
            {
                secondaryid = 72;
                secondary = blue200string;
                secondarylight = blue200lightstring;
                secondarydark = blue200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 73)
            {
                primaryid = 73;
                primary = blue300string;
                primarylight = blue300lightstring;
                primarydark = blue300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 73)
            {
                secondaryid = 73;
                secondary = blue300string;
                secondarylight = blue300lightstring;
                secondarydark = blue300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 74)
            {
                primaryid = 74;
                primary = blue400string;
                primarylight = blue400lightstring;
                primarydark = blue400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 74)
            {
                secondaryid = 74;
                secondary = blue400string;
                secondarylight = blue400lightstring;
                secondarydark = blue400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 75)
            {
                primaryid = 75;
                primary = blue500string;
                primarylight = blue500lightstring;
                primarydark = blue500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 75)
            {
                secondaryid = 75;
                secondary = blue500string;
                secondarylight = blue500lightstring;
                secondarydark = blue500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 76)
            {
                primaryid = 76;
                primary = blue600string;
                primarylight = blue600lightstring;
                primarydark = blue600darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 76)
            {
                secondaryid = 76;
                secondary = blue600string;
                secondarylight = blue600lightstring;
                secondarydark = blue600darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 77)
            {
                primaryid = 77;
                primary = blue700string;
                primarylight = blue700lightstring;
                primarydark = blue700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 77)
            {
                secondaryid = 77;
                secondary = blue700string;
                secondarylight = blue700lightstring;
                secondarydark = blue700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 78)
            {
                primaryid = 78;
                primary = blue800string;
                primarylight = blue800lightstring;
                primarydark = blue800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 78)
            {
                secondaryid = 78;
                secondary = blue800string;
                secondarylight = blue800lightstring;
                secondarydark = blue800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 79)
            {
                primaryid = 79;
                primary = blue900string;
                primarylight = blue900lightstring;
                primarydark = blue900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Blue900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 79)
            {
                secondaryid = 79;
                secondary = blue900string;
                secondarylight = blue900lightstring;
                secondarydark = blue900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluea100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 80)
            {
                primaryid = 80;
                primary = bluea100string;
                primarylight = bluea100lightstring;
                primarydark = bluea100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluea100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 80)
            {
                secondaryid = 80;
                secondary = bluea100string;
                secondarylight = bluea100lightstring;
                secondarydark = bluea100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluea200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 81)
            {
                primaryid = 81;
                primary = bluea200string;
                primarylight = bluea200lightstring;
                primarydark = bluea200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluea200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 81)
            {
                secondaryid = 81;
                secondary = bluea200string;
                secondarylight = bluea200lightstring;
                secondarydark = bluea200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluea400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 82)
            {
                primaryid = 82;
                primary = bluea400string;
                primarylight = bluea400lightstring;
                primarydark = bluea400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluea400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 82)
            {
                secondaryid = 82;
                secondary = bluea400string;
                secondarylight = bluea400lightstring;
                secondarydark = bluea400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluea700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 83)
            {
                primaryid = 83;
                primary = bluea700string;
                primarylight = bluea700lightstring;
                primarydark = bluea700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluea700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 83)
            {
                secondaryid = 83;
                secondary = bluea700string;
                secondarylight = bluea700lightstring;
                secondarydark = bluea700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 84)
            {
                primaryid = 84;
                primary = lightblue50string;
                primarylight = lightblue50lightstring;
                primarydark = lightblue50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 84)
            {
                secondaryid = 84;
                secondary = lightblue50string;
                secondarylight = lightblue50lightstring;
                secondarydark = lightblue50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 85)
            {
                primaryid = 85;
                primary = lightblue100string;
                primarylight = lightblue100lightstring;
                primarydark = lightblue100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 85)
            {
                secondaryid = 85;
                secondary = lightblue100string;
                secondarylight = lightblue100lightstring;
                secondarydark = lightblue100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 86)
            {
                primaryid = 86;
                primary = lightblue200string;
                primarylight = lightblue200lightstring;
                primarydark = lightblue200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 86)
            {
                secondaryid = 86;
                secondary = lightblue200string;
                secondarylight = lightblue200lightstring;
                secondarydark = lightblue200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 87)
            {
                primaryid = 87;
                primary = lightblue300string;
                primarylight = lightblue300lightstring;
                primarydark = lightblue300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 87)
            {
                secondaryid = 87;
                secondary = lightblue300string;
                secondarylight = lightblue300lightstring;
                secondarydark = lightblue300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 88)
            {
                primaryid = 88;
                primary = lightblue400string;
                primarylight = lightblue400lightstring;
                primarydark = lightblue400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 88)
            {
                secondaryid = 88;
                secondary = lightblue400string;
                secondarylight = lightblue400lightstring;
                secondarydark = lightblue400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 89)
            {
                primaryid = 89;
                primary = lightblue500string;
                primarylight = lightblue500lightstring;
                primarydark = lightblue500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 89)
            {
                secondaryid = 89;
                secondary = lightblue500string;
                secondarylight = lightblue500lightstring;
                secondarydark = lightblue500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 90)
            {
                primaryid = 90;
                primary = lightblue600string;
                primarylight = lightblue600lightstring;
                primarydark = lightblue600darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 90)
            {
                secondaryid = 90;
                secondary = lightblue600string;
                secondarylight = lightblue600lightstring;
                secondarydark = lightblue600darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 91)
            {
                primaryid = 91;
                primary = lightblue700string;
                primarylight = lightblue700lightstring;
                primarydark = lightblue700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 91)
            {
                secondaryid = 91;
                secondary = lightblue700string;
                secondarylight = lightblue700lightstring;
                secondarydark = lightblue700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 92)
            {
                primaryid = 92;
                primary = lightblue800string;
                primarylight = lightblue800lightstring;
                primarydark = lightblue800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 92)
            {
                secondaryid = 92;
                secondary = lightblue800string;
                secondarylight = lightblue800lightstring;
                secondarydark = lightblue800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 93)
            {
                primaryid = 93;
                primary = lightblue900string;
                primarylight = lightblue900lightstring;
                primarydark = lightblue900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightblue900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 93)
            {
                secondaryid = 93;
                secondary = lightblue900string;
                secondarylight = lightblue900lightstring;
                secondarydark = lightblue900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightbluea100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 94)
            {
                primaryid = 94;
                primary = lightbluea100string;
                primarylight = lightbluea100lightstring;
                primarydark = lightbluea100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightbluea100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 94)
            {
                secondaryid = 94;
                secondary = lightbluea100string;
                secondarylight = lightbluea100lightstring;
                secondarydark = lightbluea100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightbluea200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 95)
            {
                primaryid = 95;
                primary = lightbluea200string;
                primarylight = lightbluea200lightstring;
                primarydark = lightbluea200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightbluea200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 95)
            {
                secondaryid = 95;
                secondary = lightbluea200string;
                secondarylight = lightbluea200lightstring;
                secondarydark = lightbluea200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightbluea400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 96)
            {
                primaryid = 96;
                primary = lightbluea400string;
                primarylight = lightbluea400lightstring;
                primarydark = lightbluea400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightbluea400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 96)
            {
                secondaryid = 96;
                secondary = lightbluea400string;
                secondarylight = lightbluea400lightstring;
                secondarydark = lightbluea400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightbluea700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 97)
            {
                primaryid = 97;
                primary = lightbluea700string;
                primarylight = lightbluea700lightstring;
                primarydark = lightbluea700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightbluea700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 97)
            {
                secondaryid = 97;
                secondary = lightbluea700string;
                secondarylight = lightbluea700lightstring;
                secondarydark = lightbluea700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 98)
            {
                primaryid = 98;
                primary = cyan50string;
                primarylight = cyan50lightstring;
                primarydark = cyan50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 98)
            {
                secondaryid = 98;
                secondary = cyan50string;
                secondarylight = cyan50lightstring;
                secondarydark = cyan50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 99)
            {
                primaryid = 99;
                primary = cyan100string;
                primarylight = cyan100lightstring;
                primarydark = cyan100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 99)
            {
                secondaryid = 99;
                secondary = cyan100string;
                secondarylight = cyan100lightstring;
                secondarydark = cyan100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 100)
            {
                primaryid = 100;
                primary = cyan200string;
                primarylight = cyan200lightstring;
                primarydark = cyan200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 100)
            {
                secondaryid = 100;
                secondary = cyan200string;
                secondarylight = cyan200lightstring;
                secondarydark = cyan200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 101)
            {
                primaryid = 101;
                primary = cyan300string;
                primarylight = cyan300lightstring;
                primarydark = cyan300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 101)
            {
                secondaryid = 101;
                secondary = cyan300string;
                secondarylight = cyan300lightstring;
                secondarydark = cyan300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 102)
            {
                primaryid = 102;
                primary = cyan400string;
                primarylight = cyan400lightstring;
                primarydark = cyan400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 102)
            {
                secondaryid = 102;
                secondary = cyan400string;
                secondarylight = cyan400lightstring;
                secondarydark = cyan400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 103)
            {
                primaryid = 103;
                primary = cyan500string;
                primarylight = cyan500lightstring;
                primarydark = cyan500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 103)
            {
                secondaryid = 103;
                secondary = cyan500string;
                secondarylight = cyan500lightstring;
                secondarydark = cyan500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 104)
            {
                primaryid = 104;
                primary = cyan600string;
                primarylight = cyan600lightstring;
                primarydark = cyan600darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 104)
            {
                secondaryid = 104;
                secondary = cyan600string;
                secondarylight = cyan600lightstring;
                secondarydark = cyan600darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 105)
            {
                primaryid = 105;
                primary = cyan700string;
                primarylight = cyan700lightstring;
                primarydark = cyan700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 105)
            {
                secondaryid = 105;
                secondary = cyan700string;
                secondarylight = cyan700lightstring;
                secondarydark = cyan700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 106)
            {
                primaryid = 106;
                primary = cyan800string;
                primarylight = cyan800lightstring;
                primarydark = cyan800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 106)
            {
                secondaryid = 106;
                secondary = cyan800string;
                secondarylight = cyan800lightstring;
                secondarydark = cyan800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 107)
            {
                primaryid = 107;
                primary = cyan900string;
                primarylight = cyan900lightstring;
                primarydark = cyan900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyan900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 107)
            {
                secondaryid = 107;
                secondary = cyan900string;
                secondarylight = cyan900lightstring;
                secondarydark = cyan900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyana100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 108)
            {
                primaryid = 108;
                primary = cyana100string;
                primarylight = cyana100lightstring;
                primarydark = cyana100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyana100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 108)
            {
                secondaryid = 108;
                secondary = cyana100string;
                secondarylight = cyana100lightstring;
                secondarydark = cyana100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyana200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 109)
            {
                primaryid = 109;
                primary = cyana200string;
                primarylight = cyana200lightstring;
                primarydark = cyana200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyana200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 109)
            {
                secondaryid = 109;
                secondary = cyana200string;
                secondarylight = cyana200lightstring;
                secondarydark = cyana200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyana400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 110)
            {
                primaryid = 110;
                primary = cyana400string;
                primarylight = cyana400lightstring;
                primarydark = cyana400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyana400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 110)
            {
                secondaryid = 110;
                secondary = cyana400string;
                secondarylight = cyana400lightstring;
                secondarydark = cyana400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyana700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 111)
            {
                primaryid = 111;
                primary = cyana700string;
                primarylight = cyana700lightstring;
                primarydark = cyana700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Cyana700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 111)
            {
                secondaryid = 111;
                secondary = cyana700string;
                secondarylight = cyana700lightstring;
                secondarydark = cyana700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 112)
            {
                primaryid = 112;
                primary = teal50string;
                primarylight = teal50lightstring;
                primarydark = teal50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 112)
            {
                secondaryid = 112;
                secondary = teal50string;
                secondarylight = teal50lightstring;
                secondarydark = teal50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 113)
            {
                primaryid = 113;
                primary = teal100string;
                primarylight = teal100lightstring;
                primarydark = teal100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 113)
            {
                secondaryid = 113;
                secondary = teal100string;
                secondarylight = teal100lightstring;
                secondarydark = teal100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 114)
            {
                primaryid = 114;
                primary = teal200string;
                primarylight = teal200lightstring;
                primarydark = teal200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 114)
            {
                secondaryid = 114;
                secondary = teal200string;
                secondarylight = teal200lightstring;
                secondarydark = teal200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 115)
            {
                primaryid = 115;
                primary = teal300string;
                primarylight = teal300lightstring;
                primarydark = teal300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 115)
            {
                secondaryid = 115;
                secondary = teal300string;
                secondarylight = teal300lightstring;
                secondarydark = teal300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 116)
            {
                primaryid = 116;
                primary = teal400string;
                primarylight = teal400lightstring;
                primarydark = teal400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 116)
            {
                secondaryid = 116;
                secondary = teal400string;
                secondarylight = teal400lightstring;
                secondarydark = teal400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 117)
            {
                primaryid = 117;
                primary = teal500string;
                primarylight = teal500lightstring;
                primarydark = teal500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 117)
            {
                secondaryid = 117;
                secondary = teal500string;
                secondarylight = teal500lightstring;
                secondarydark = teal500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 118)
            {
                primaryid = 118;
                primary = teal600string;
                primarylight = teal600lightstring;
                primarydark = teal600darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 118)
            {
                secondaryid = 118;
                secondary = teal600string;
                secondarylight = teal600lightstring;
                secondarydark = teal600darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 119)
            {
                primaryid = 119;
                primary = teal700string;
                primarylight = teal700lightstring;
                primarydark = teal700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 119)
            {
                secondaryid = 119;
                secondary = teal700string;
                secondarylight = teal700lightstring;
                secondarydark = teal700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 120)
            {
                primaryid = 120;
                primary = teal800string;
                primarylight = teal800lightstring;
                primarydark = teal800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 120)
            {
                secondaryid = 120;
                secondary = teal800string;
                secondarylight = teal800lightstring;
                secondarydark = teal800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 121)
            {
                primaryid = 121;
                primary = teal900string;
                primarylight = teal900lightstring;
                primarydark = teal900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teal900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 121)
            {
                secondaryid = 121;
                secondary = teal900string;
                secondarylight = teal900lightstring;
                secondarydark = teal900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teala100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 122)
            {
                primaryid = 122;
                primary = teala100string;
                primarylight = teala100lightstring;
                primarydark = teala100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teala100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 122)
            {
                secondaryid = 122;
                secondary = teala100string;
                secondarylight = teala100lightstring;
                secondarydark = teala100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teala200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 123)
            {
                primaryid = 123;
                primary = teala200string;
                primarylight = teala200lightstring;
                primarydark = teala200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teala200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 123)
            {
                secondaryid = 123;
                secondary = teala200string;
                secondarylight = teala200lightstring;
                secondarydark = teala200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teala400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 124)
            {
                primaryid = 124;
                primary = teala400string;
                primarylight = teala400lightstring;
                primarydark = teala400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teala400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 124)
            {
                secondaryid = 124;
                secondary = teala400string;
                secondarylight = teala400lightstring;
                secondarydark = teala400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teala700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 125)
            {
                primaryid = 125;
                primary = teala700string;
                primarylight = teala700lightstring;
                primarydark = teala700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Teala700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 125)
            {
                secondaryid = 125;
                secondary = teala700string;
                secondarylight = teala700lightstring;
                secondarydark = teala700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 126)
            {
                primaryid = 126;
                primary = green50string;
                primarylight = green50lightstring;
                primarydark = green50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 126)
            {
                secondaryid = 126;
                secondary = green50string;
                secondarylight = green50lightstring;
                secondarydark = green50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 127)
            {
                primaryid = 127;
                primary = green100string;
                primarylight = green100lightstring;
                primarydark = green100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 127)
            {
                secondaryid = 127;
                secondary = green100string;
                secondarylight = green100lightstring;
                secondarydark = green100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 128)
            {
                primaryid = 128;
                primary = green200string;
                primarylight = green200lightstring;
                primarydark = green200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 128)
            {
                secondaryid = 128;
                secondary = green200string;
                secondarylight = green200lightstring;
                secondarydark = green200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 129)
            {
                primaryid = 129;
                primary = green300string;
                primarylight = green300lightstring;
                primarydark = green300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 129)
            {
                secondaryid = 129;
                secondary = green300string;
                secondarylight = green300lightstring;
                secondarydark = green300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 130)
            {
                primaryid = 130;
                primary = green400string;
                primarylight = green400lightstring;
                primarydark = green400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 130)
            {
                secondaryid = 130;
                secondary = green400string;
                secondarylight = green400lightstring;
                secondarydark = green400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 131)
            {
                primaryid = 131;
                primary = green500string;
                primarylight = green500lightstring;
                primarydark = green500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 131)
            {
                secondaryid = 131;
                secondary = green500string;
                secondarylight = green500lightstring;
                secondarydark = green500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 132)
            {
                primaryid = 132;
                primary = green600string;
                primarylight = green600lightstring;
                primarydark = green600darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 132)
            {
                secondaryid = 132;
                secondary = green600string;
                secondarylight = green600lightstring;
                secondarydark = green600darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 133)
            {
                primaryid = 133;
                primary = green700string;
                primarylight = green700lightstring;
                primarydark = green700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 133)
            {
                secondaryid = 133;
                secondary = green700string;
                secondarylight = green700lightstring;
                secondarydark = green700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 134)
            {
                primaryid = 134;
                primary = green800string;
                primarylight = green800lightstring;
                primarydark = green800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 134)
            {
                secondaryid = 134;
                secondary = green800string;
                secondarylight = green800lightstring;
                secondarydark = green800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 135)
            {
                primaryid = 135;
                primary = green900string;
                primarylight = green900lightstring;
                primarydark = green900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Green900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 135)
            {
                secondaryid = 135;
                secondary = green900string;
                secondarylight = green900lightstring;
                secondarydark = green900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Greena100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 136)
            {
                primaryid = 136;
                primary = greena100string;
                primarylight = greena100lightstring;
                primarydark = greena100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Greena100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 136)
            {
                secondaryid = 136;
                secondary = greena100string;
                secondarylight = greena100lightstring;
                secondarydark = greena100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Greena200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 137)
            {
                primaryid = 137;
                primary = greena200string;
                primarylight = greena200lightstring;
                primarydark = greena200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Greena200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 137)
            {
                secondaryid = 137;
                secondary = greena200string;
                secondarylight = greena200lightstring;
                secondarydark = greena200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Greena400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 138)
            {
                primaryid = 138;
                primary = greena400string;
                primarylight = greena400lightstring;
                primarydark = greena400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Greena400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 138)
            {
                secondaryid = 138;
                secondary = greena400string;
                secondarylight = greena400lightstring;
                secondarydark = greena400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Greena700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 139)
            {
                primaryid = 139;
                primary = greena700string;
                primarylight = greena700lightstring;
                primarydark = greena700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Greena700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 139)
            {
                secondaryid = 139;
                secondary = greena700string;
                secondarylight = greena700lightstring;
                secondarydark = greena700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 140)
            {
                primaryid = 140;
                primary = lightgreen50string;
                primarylight = lightgreen50lightstring;
                primarydark = lightgreen50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 140)
            {
                secondaryid = 140;
                secondary = lightgreen50string;
                secondarylight = lightgreen50lightstring;
                secondarydark = lightgreen50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 141)
            {
                primaryid = 141;
                primary = lightgreen100string;
                primarylight = lightgreen100lightstring;
                primarydark = lightgreen100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 141)
            {
                secondaryid = 141;
                secondary = lightgreen100string;
                secondarylight = lightgreen100lightstring;
                secondarydark = lightgreen100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 142)
            {
                primaryid = 142;
                primary = lightgreen200string;
                primarylight = lightgreen200lightstring;
                primarydark = lightgreen200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 142)
            {
                secondaryid = 142;
                secondary = lightgreen200string;
                secondarylight = lightgreen200lightstring;
                secondarydark = lightgreen200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 143)
            {
                primaryid = 143;
                primary = lightgreen300string;
                primarylight = lightgreen300lightstring;
                primarydark = lightgreen300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 143)
            {
                secondaryid = 143;
                secondary = lightgreen300string;
                secondarylight = lightgreen300lightstring;
                secondarydark = lightgreen300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 144)
            {
                primaryid = 144;
                primary = lightgreen400string;
                primarylight = lightgreen400lightstring;
                primarydark = lightgreen400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 144)
            {
                secondaryid = 144;
                secondary = lightgreen400string;
                secondarylight = lightgreen400lightstring;
                secondarydark = lightgreen400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 145)
            {
                primaryid = 145;
                primary = lightgreen500string;
                primarylight = lightgreen500lightstring;
                primarydark = lightgreen500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 145)
            {
                secondaryid = 145;
                secondary = lightgreen500string;
                secondarylight = lightgreen500lightstring;
                secondarydark = lightgreen500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 146)
            {
                primaryid = 146;
                primary = lightgreen600string;
                primarylight = lightgreen600lightstring;
                primarydark = lightgreen600darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 146)
            {
                secondaryid = 146;
                secondary = lightgreen600string;
                secondarylight = lightgreen600lightstring;
                secondarydark = lightgreen600darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 147)
            {
                primaryid = 147;
                primary = lightgreen700string;
                primarylight = lightgreen700lightstring;
                primarydark = lightgreen700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 147)
            {
                secondaryid = 147;
                secondary = lightgreen700string;
                secondarylight = lightgreen700lightstring;
                secondarydark = lightgreen700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 148)
            {
                primaryid = 148;
                primary = lightgreen800string;
                primarylight = lightgreen800lightstring;
                primarydark = lightgreen800darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 148)
            {
                secondaryid = 148;
                secondary = lightgreen800string;
                secondarylight = lightgreen800lightstring;
                secondarydark = lightgreen800darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 149)
            {
                primaryid = 149;
                primary = lightgreen900string;
                primarylight = lightgreen900lightstring;
                primarydark = lightgreen900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreen900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 149)
            {
                secondaryid = 149;
                secondary = lightgreen900string;
                secondarylight = lightgreen900lightstring;
                secondarydark = lightgreen900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreena100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 150)
            {
                primaryid = 150;
                primary = lightgreena100string;
                primarylight = lightgreena100lightstring;
                primarydark = lightgreena100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreena100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 150)
            {
                secondaryid = 150;
                secondary = lightgreena100string;
                secondarylight = lightgreena100lightstring;
                secondarydark = lightgreena100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreena200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 151)
            {
                primaryid = 151;
                primary = lightgreena200string;
                primarylight = lightgreena200lightstring;
                primarydark = lightgreena200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreena200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 151)
            {
                secondaryid = 151;
                secondary = lightgreena200string;
                secondarylight = lightgreena200lightstring;
                secondarydark = lightgreena200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreena400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 152)
            {
                primaryid = 152;
                primary = lightgreena400string;
                primarylight = lightgreena400lightstring;
                primarydark = lightgreena400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreena400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 152)
            {
                secondaryid = 152;
                secondary = lightgreena400string;
                secondarylight = lightgreena400lightstring;
                secondarydark = lightgreena400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreena700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 153)
            {
                primaryid = 153;
                primary = lightgreena700string;
                primarylight = lightgreena700lightstring;
                primarydark = lightgreena700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lightgreena700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 153)
            {
                secondaryid = 153;
                secondary = lightgreena700string;
                secondarylight = lightgreena700lightstring;
                secondarydark = lightgreena700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 154)
            {
                primaryid = 154;
                primary = lime50string;
                primarylight = lime50lightstring;
                primarydark = lime50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 154)
            {
                secondaryid = 154;
                secondary = lime50string;
                secondarylight = lime50lightstring;
                secondarydark = lime50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 155)
            {
                primaryid = 155;
                primary = lime100string;
                primarylight = lime100lightstring;
                primarydark = lime100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 155)
            {
                secondaryid = 155;
                secondary = lime100string;
                secondarylight = lime100lightstring;
                secondarydark = lime100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 156)
            {
                primaryid = 156;
                primary = lime200string;
                primarylight = lime200lightstring;
                primarydark = lime200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 156)
            {
                secondaryid = 156;
                secondary = lime200string;
                secondarylight = lime200lightstring;
                secondarydark = lime200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 157)
            {
                primaryid = 157;
                primary = lime300string;
                primarylight = lime300lightstring;
                primarydark = lime300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 157)
            {
                secondaryid = 157;
                secondary = lime300string;
                secondarylight = lime300lightstring;
                secondarydark = lime300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 158)
            {
                primaryid = 158;
                primary = lime400string;
                primarylight = lime400lightstring;
                primarydark = lime400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 158)
            {
                secondaryid = 158;
                secondary = lime400string;
                secondarylight = lime400lightstring;
                secondarydark = lime400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 159)
            {
                primaryid = 159;
                primary = lime500string;
                primarylight = lime500lightstring;
                primarydark = lime500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 159)
            {
                secondaryid = 159;
                secondary = lime500string;
                secondarylight = lime500lightstring;
                secondarydark = lime500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 160)
            {
                primaryid = 160;
                primary = lime600string;
                primarylight = lime600lightstring;
                primarydark = lime600darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 160)
            {
                secondaryid = 160;
                secondary = lime600string;
                secondarylight = lime600lightstring;
                secondarydark = lime600darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 161)
            {
                primaryid = 161;
                primary = lime700string;
                primarylight = lime700lightstring;
                primarydark = lime700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 161)
            {
                secondaryid = 161;
                secondary = lime700string;
                secondarylight = lime700lightstring;
                secondarydark = lime700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 162)
            {
                primaryid = 162;
                primary = lime800string;
                primarylight = lime800lightstring;
                primarydark = lime800darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 162)
            {
                secondaryid = 162;
                secondary = lime800string;
                secondarylight = lime800lightstring;
                secondarydark = lime800darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 163)
            {
                primaryid = 163;
                primary = lime900string;
                primarylight = lime900lightstring;
                primarydark = lime900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Lime900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 163)
            {
                secondaryid = 163;
                secondary = lime900string;
                secondarylight = lime900lightstring;
                secondarydark = lime900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Limea100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 164)
            {
                primaryid = 164;
                primary = limea100string;
                primarylight = limea100lightstring;
                primarydark = limea100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Limea100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 164)
            {
                secondaryid = 164;
                secondary = limea100string;
                secondarylight = limea100lightstring;
                secondarydark = limea100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Limea200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 165)
            {
                primaryid = 165;
                primary = limea200string;
                primarylight = limea200lightstring;
                primarydark = limea200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Limea200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 165)
            {
                secondaryid = 165;
                secondary = limea200string;
                secondarylight = limea200lightstring;
                secondarydark = limea200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Limea400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 166)
            {
                primaryid = 166;
                primary = limea400string;
                primarylight = limea400lightstring;
                primarydark = limea400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Limea400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 166)
            {
                secondaryid = 166;
                secondary = limea400string;
                secondarylight = limea400lightstring;
                secondarydark = limea400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Limea700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 167)
            {
                primaryid = 167;
                primary = limea700string;
                primarylight = limea700lightstring;
                primarydark = limea700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Limea700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 167)
            {
                secondaryid = 167;
                secondary = limea700string;
                secondarylight = limea700lightstring;
                secondarydark = limea700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 168)
            {
                primaryid = 168;
                primary = yellow50string;
                primarylight = yellow50lightstring;
                primarydark = yellow50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 168)
            {
                secondaryid = 168;
                secondary = yellow50string;
                secondarylight = yellow50lightstring;
                secondarydark = yellow50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 169)
            {
                primaryid = 169;
                primary = yellow100string;
                primarylight = yellow100lightstring;
                primarydark = yellow100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 169)
            {
                secondaryid = 169;
                secondary = yellow100string;
                secondarylight = yellow100lightstring;
                secondarydark = yellow100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 170)
            {
                primaryid = 170;
                primary = yellow200string;
                primarylight = yellow200lightstring;
                primarydark = yellow200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 170)
            {
                secondaryid = 170;
                secondary = yellow200string;
                secondarylight = yellow200lightstring;
                secondarydark = yellow200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 171)
            {
                primaryid = 171;
                primary = yellow300string;
                primarylight = yellow300lightstring;
                primarydark = yellow300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 171)
            {
                secondaryid = 171;
                secondary = yellow300string;
                secondarylight = yellow300lightstring;
                secondarydark = yellow300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 172)
            {
                primaryid = 172;
                primary = yellow400string;
                primarylight = yellow400lightstring;
                primarydark = yellow400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 172)
            {
                secondaryid = 172;
                secondary = yellow400string;
                secondarylight = yellow400lightstring;
                secondarydark = yellow400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 173)
            {
                primaryid = 173;
                primary = yellow500string;
                primarylight = yellow500lightstring;
                primarydark = yellow500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 173)
            {
                secondaryid = 173;
                secondary = yellow500string;
                secondarylight = yellow500lightstring;
                secondarydark = yellow500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 174)
            {
                primaryid = 174;
                primary = yellow600string;
                primarylight = yellow600lightstring;
                primarydark = yellow600darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 174)
            {
                secondaryid = 174;
                secondary = yellow600string;
                secondarylight = yellow600lightstring;
                secondarydark = yellow600darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 175)
            {
                primaryid = 175;
                primary = yellow700string;
                primarylight = yellow700lightstring;
                primarydark = yellow700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 175)
            {
                secondaryid = 175;
                secondary = yellow700string;
                secondarylight = yellow700lightstring;
                secondarydark = yellow700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 176)
            {
                primaryid = 176;
                primary = yellow800string;
                primarylight = yellow800lightstring;
                primarydark = yellow800darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 176)
            {
                secondaryid = 176;
                secondary = yellow800string;
                secondarylight = yellow800lightstring;
                secondarydark = yellow800darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 177)
            {
                primaryid = 177;
                primary = yellow900string;
                primarylight = yellow900lightstring;
                primarydark = yellow900darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellow900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 177)
            {
                secondaryid = 177;
                secondary = yellow900string;
                secondarylight = yellow900lightstring;
                secondarydark = yellow900darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellowa100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 178)
            {
                primaryid = 178;
                primary = yellowa100string;
                primarylight = yellowa100lightstring;
                primarydark = yellowa100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellowa100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 178)
            {
                secondaryid = 178;
                secondary = yellowa100string;
                secondarylight = yellowa100lightstring;
                secondarydark = yellowa100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellowa200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 179)
            {
                primaryid = 179;
                primary = yellowa200string;
                primarylight = yellowa200lightstring;
                primarydark = yellowa200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellowa200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 179)
            {
                secondaryid = 179;
                secondary = yellowa200string;
                secondarylight = yellowa200lightstring;
                secondarydark = yellowa200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellowa400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 180)
            {
                primaryid = 180;
                primary = yellowa400string;
                primarylight = yellowa400lightstring;
                primarydark = yellowa400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellowa400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 180)
            {
                secondaryid = 180;
                secondary = yellowa400string;
                secondarylight = yellowa400lightstring;
                secondarydark = yellowa400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellowa700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 181)
            {
                primaryid = 181;
                primary = yellowa700string;
                primarylight = yellowa700lightstring;
                primarydark = yellowa700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Yellowa700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 181)
            {
                secondaryid = 181;
                secondary = yellowa700string;
                secondarylight = yellowa700lightstring;
                secondarydark = yellowa700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 182)
            {
                primaryid = 182;
                primary = amber50string;
                primarylight = amber50lightstring;
                primarydark = amber50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 182)
            {
                secondaryid = 182;
                secondary = amber50string;
                secondarylight = amber50lightstring;
                secondarydark = amber50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 183)
            {
                primaryid = 183;
                primary = amber100string;
                primarylight = amber100lightstring;
                primarydark = amber100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 183)
            {
                secondaryid = 183;
                secondary = amber100string;
                secondarylight = amber100lightstring;
                secondarydark = amber100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 184)
            {
                primaryid = 184;
                primary = amber200string;
                primarylight = amber200lightstring;
                primarydark = amber200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 184)
            {
                secondaryid = 184;
                secondary = amber200string;
                secondarylight = amber200lightstring;
                secondarydark = amber200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 185)
            {
                primaryid = 185;
                primary = amber300string;
                primarylight = amber300lightstring;
                primarydark = amber300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 185)
            {
                secondaryid = 185;
                secondary = amber300string;
                secondarylight = amber300lightstring;
                secondarydark = amber300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 186)
            {
                primaryid = 186;
                primary = amber400string;
                primarylight = amber400lightstring;
                primarydark = amber400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 186)
            {
                secondaryid = 186;
                secondary = amber400string;
                secondarylight = amber400lightstring;
                secondarydark = amber400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 187)
            {
                primaryid = 187;
                primary = amber500string;
                primarylight = amber500lightstring;
                primarydark = amber500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 187)
            {
                secondaryid = 187;
                secondary = amber500string;
                secondarylight = amber500lightstring;
                secondarydark = amber500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 188)
            {
                primaryid = 188;
                primary = amber600string;
                primarylight = amber600lightstring;
                primarydark = amber600darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 188)
            {
                secondaryid = 188;
                secondary = amber600string;
                secondarylight = amber600lightstring;
                secondarydark = amber600darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 189)
            {
                primaryid = 189;
                primary = amber700string;
                primarylight = amber700lightstring;
                primarydark = amber700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 189)
            {
                secondaryid = 189;
                secondary = amber700string;
                secondarylight = amber700lightstring;
                secondarydark = amber700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 190)
            {
                primaryid = 190;
                primary = amber800string;
                primarylight = amber800lightstring;
                primarydark = amber800darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 190)
            {
                secondaryid = 190;
                secondary = amber800string;
                secondarylight = amber800lightstring;
                secondarydark = amber800darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 191)
            {
                primaryid = 191;
                primary = amber900string;
                primarylight = amber900lightstring;
                primarydark = amber900darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Amber900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 191)
            {
                secondaryid = 191;
                secondary = amber900string;
                secondarylight = amber900lightstring;
                secondarydark = amber900darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Ambera100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 192)
            {
                primaryid = 192;
                primary = ambera100string;
                primarylight = ambera100lightstring;
                primarydark = ambera100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Ambera100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 192)
            {
                secondaryid = 192;
                secondary = ambera100string;
                secondarylight = ambera100lightstring;
                secondarydark = ambera100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Ambera200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 193)
            {
                primaryid = 193;
                primary = ambera200string;
                primarylight = ambera200lightstring;
                primarydark = ambera200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Ambera200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 193)
            {
                secondaryid = 193;
                secondary = ambera200string;
                secondarylight = ambera200lightstring;
                secondarydark = ambera200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Ambera400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 194)
            {
                primaryid = 194;
                primary = ambera400string;
                primarylight = ambera400lightstring;
                primarydark = ambera400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Ambera400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 194)
            {
                secondaryid = 194;
                secondary = ambera400string;
                secondarylight = ambera400lightstring;
                secondarydark = ambera400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Ambera700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 195)
            {
                primaryid = 195;
                primary = ambera700string;
                primarylight = ambera700lightstring;
                primarydark = ambera700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Ambera700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 195)
            {
                secondaryid = 195;
                secondary = ambera700string;
                secondarylight = ambera700lightstring;
                secondarydark = ambera700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 196)
            {
                primaryid = 196;
                primary = orange50string;
                primarylight = orange50lightstring;
                primarydark = orange50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 196)
            {
                secondaryid = 196;
                secondary = orange50string;
                secondarylight = orange50lightstring;
                secondarydark = orange50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 197)
            {
                primaryid = 197;
                primary = orange100string;
                primarylight = orange100lightstring;
                primarydark = orange100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 197)
            {
                secondaryid = 197;
                secondary = orange100string;
                secondarylight = orange100lightstring;
                secondarydark = orange100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 198)
            {
                primaryid = 198;
                primary = orange200string;
                primarylight = orange200lightstring;
                primarydark = orange200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 198)
            {
                secondaryid = 198;
                secondary = orange200string;
                secondarylight = orange200lightstring;
                secondarydark = orange200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 199)
            {
                primaryid = 199;
                primary = orange300string;
                primarylight = orange300lightstring;
                primarydark = orange300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 199)
            {
                secondaryid = 199;
                secondary = orange300string;
                secondarylight = orange300lightstring;
                secondarydark = orange300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 200)
            {
                primaryid = 200;
                primary = orange400string;
                primarylight = orange400lightstring;
                primarydark = orange400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 200)
            {
                secondaryid = 200;
                secondary = orange400string;
                secondarylight = orange400lightstring;
                secondarydark = orange400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 201)
            {
                primaryid = 201;
                primary = orange500string;
                primarylight = orange500lightstring;
                primarydark = orange500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 201)
            {
                secondaryid = 201;
                secondary = orange500string;
                secondarylight = orange500lightstring;
                secondarydark = orange500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 202)
            {
                primaryid = 202;
                primary = orange600string;
                primarylight = orange600lightstring;
                primarydark = orange600darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 202)
            {
                secondaryid = 202;
                secondary = orange600string;
                secondarylight = orange600lightstring;
                secondarydark = orange600darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 203)
            {
                primaryid = 203;
                primary = orange700string;
                primarylight = orange700lightstring;
                primarydark = orange700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 203)
            {
                secondaryid = 203;
                secondary = orange700string;
                secondarylight = orange700lightstring;
                secondarydark = orange700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 204)
            {
                primaryid = 204;
                primary = orange800string;
                primarylight = orange800lightstring;
                primarydark = orange800darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 204)
            {
                secondaryid = 204;
                secondary = orange800string;
                secondarylight = orange800lightstring;
                secondarydark = orange800darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 205)
            {
                primaryid = 205;
                primary = orange900string;
                primarylight = orange900lightstring;
                primarydark = orange900darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orange900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 205)
            {
                secondaryid = 205;
                secondary = orange900string;
                secondarylight = orange900lightstring;
                secondarydark = orange900darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orangea100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 206)
            {
                primaryid = 206;
                primary = orangea100string;
                primarylight = orangea100lightstring;
                primarydark = orangea100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orangea100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 206)
            {
                secondaryid = 206;
                secondary = orangea100string;
                secondarylight = orangea100lightstring;
                secondarydark = orangea100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orangea200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 207)
            {
                primaryid = 207;
                primary = orangea200string;
                primarylight = orangea200lightstring;
                primarydark = orangea200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orangea200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 207)
            {
                secondaryid = 207;
                secondary = orangea200string;
                secondarylight = orangea200lightstring;
                secondarydark = orangea200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orangea400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 208)
            {
                primaryid = 208;
                primary = orangea400string;
                primarylight = orangea400lightstring;
                primarydark = orangea400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orangea400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 208)
            {
                secondaryid = 208;
                secondary = orangea400string;
                secondarylight = orangea400lightstring;
                secondarydark = orangea400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orangea700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 209)
            {
                primaryid = 209;
                primary = orangea700string;
                primarylight = orangea700lightstring;
                primarydark = orangea700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Orangea700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 209)
            {
                secondaryid = 209;
                secondary = orangea700string;
                secondarylight = orangea700lightstring;
                secondarydark = orangea700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 210)
            {
                primaryid = 210;
                primary = deeporange50string;
                primarylight = deeporange50lightstring;
                primarydark = deeporange50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 210)
            {
                secondaryid = 210;
                secondary = deeporange50string;
                secondarylight = deeporange50lightstring;
                secondarydark = deeporange50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 211)
            {
                primaryid = 211;
                primary = deeporange100string;
                primarylight = deeporange100lightstring;
                primarydark = deeporange100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 211)
            {
                secondaryid = 211;
                secondary = deeporange100string;
                secondarylight = deeporange100lightstring;
                secondarydark = deeporange100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 212)
            {
                primaryid = 212;
                primary = deeporange200string;
                primarylight = deeporange200lightstring;
                primarydark = deeporange200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 212)
            {
                secondaryid = 212;
                secondary = deeporange200string;
                secondarylight = deeporange200lightstring;
                secondarydark = deeporange200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 213)
            {
                primaryid = 213;
                primary = deeporange300string;
                primarylight = deeporange300lightstring;
                primarydark = deeporange300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 213)
            {
                secondaryid = 213;
                secondary = deeporange300string;
                secondarylight = deeporange300lightstring;
                secondarydark = deeporange300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 214)
            {
                primaryid = 214;
                primary = deeporange400string;
                primarylight = deeporange400lightstring;
                primarydark = deeporange400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 214)
            {
                secondaryid = 214;
                secondary = deeporange400string;
                secondarylight = deeporange400lightstring;
                secondarydark = deeporange400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 215)
            {
                primaryid = 215;
                primary = deeporange500string;
                primarylight = deeporange500lightstring;
                primarydark = deeporange500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 215)
            {
                secondaryid = 215;
                secondary = deeporange500string;
                secondarylight = deeporange500lightstring;
                secondarydark = deeporange500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 216)
            {
                primaryid = 216;
                primary = deeporange600string;
                primarylight = deeporange600lightstring;
                primarydark = deeporange600darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 216)
            {
                secondaryid = 216;
                secondary = deeporange600string;
                secondarylight = deeporange600lightstring;
                secondarydark = deeporange600darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 217)
            {
                primaryid = 217;
                primary = deeporange700string;
                primarylight = deeporange700lightstring;
                primarydark = deeporange700darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 217)
            {
                secondaryid = 217;
                secondary = deeporange700string;
                secondarylight = deeporange700lightstring;
                secondarydark = deeporange700darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 218)
            {
                primaryid = 218;
                primary = deeporange800string;
                primarylight = deeporange800lightstring;
                primarydark = deeporange800darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 218)
            {
                secondaryid = 218;
                secondary = deeporange800string;
                secondarylight = deeporange800lightstring;
                secondarydark = deeporange800darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 219)
            {
                primaryid = 219;
                primary = deeporange900string;
                primarylight = deeporange900lightstring;
                primarydark = deeporange900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporange900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 219)
            {
                secondaryid = 219;
                secondary = deeporange900string;
                secondarylight = deeporange900lightstring;
                secondarydark = deeporange900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporangea100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 220)
            {
                primaryid = 220;
                primary = deeporangea100string;
                primarylight = deeporangea100lightstring;
                primarydark = deeporangea100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporangea100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 220)
            {
                secondaryid = 220;
                secondary = deeporangea100string;
                secondarylight = deeporangea100lightstring;
                secondarydark = deeporangea100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporangea200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 221)
            {
                primaryid = 221;
                primary = deeporangea200string;
                primarylight = deeporangea200lightstring;
                primarydark = deeporangea200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporangea200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 221)
            {
                secondaryid = 221;
                secondary = deeporangea200string;
                secondarylight = deeporangea200lightstring;
                secondarydark = deeporangea200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporangea400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 222)
            {
                primaryid = 222;
                primary = deeporangea400string;
                primarylight = deeporangea400lightstring;
                primarydark = deeporangea400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporangea400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 222)
            {
                secondaryid = 222;
                secondary = deeporangea400string;
                secondarylight = deeporangea400lightstring;
                secondarydark = deeporangea400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporangea700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 223)
            {
                primaryid = 223;
                primary = deeporangea700string;
                primarylight = deeporangea700lightstring;
                primarydark = deeporangea700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Deeporangea700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 223)
            {
                secondaryid = 223;
                secondary = deeporangea700string;
                secondarylight = deeporangea700lightstring;
                secondarydark = deeporangea700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 224)
            {
                primaryid = 224;
                primary = brown50string;
                primarylight = brown50lightstring;
                primarydark = brown50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 224)
            {
                secondaryid = 224;
                secondary = brown50string;
                secondarylight = brown50lightstring;
                secondarydark = brown50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 225)
            {
                primaryid = 225;
                primary = brown100string;
                primarylight = brown100lightstring;
                primarydark = brown100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 225)
            {
                secondaryid = 225;
                secondary = brown100string;
                secondarylight = brown100lightstring;
                secondarydark = brown100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 226)
            {
                primaryid = 226;
                primary = brown200string;
                primarylight = brown200lightstring;
                primarydark = brown200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 226)
            {
                secondaryid = 226;
                secondary = brown200string;
                secondarylight = brown200lightstring;
                secondarydark = brown200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 227)
            {
                primaryid = 227;
                primary = brown300string;
                primarylight = brown300lightstring;
                primarydark = brown300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 227)
            {
                secondaryid = 227;
                secondary = brown300string;
                secondarylight = brown300lightstring;
                secondarydark = brown300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 228)
            {
                primaryid = 228;
                primary = brown400string;
                primarylight = brown400lightstring;
                primarydark = brown400darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 228)
            {
                secondaryid = 228;
                secondary = brown400string;
                secondarylight = brown400lightstring;
                secondarydark = brown400darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 229)
            {
                primaryid = 229;
                primary = brown500string;
                primarylight = brown500lightstring;
                primarydark = brown500darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 229)
            {
                secondaryid = 229;
                secondary = brown500string;
                secondarylight = brown500lightstring;
                secondarydark = brown500darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 230)
            {
                primaryid = 230;
                primary = brown600string;
                primarylight = brown600lightstring;
                primarydark = brown600darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 230)
            {
                secondaryid = 230;
                secondary = brown600string;
                secondarylight = brown600lightstring;
                secondarydark = brown600darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 231)
            {
                primaryid = 231;
                primary = brown700string;
                primarylight = brown700lightstring;
                primarydark = brown700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 231)
            {
                secondaryid = 231;
                secondary = brown700string;
                secondarylight = brown700lightstring;
                secondarydark = brown700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 232)
            {
                primaryid = 232;
                primary = brown800string;
                primarylight = brown800lightstring;
                primarydark = brown800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 232)
            {
                secondaryid = 232;
                secondary = brown800string;
                secondarylight = brown800lightstring;
                secondarydark = brown800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 233)
            {
                primaryid = 233;
                primary = brown900string;
                primarylight = brown900lightstring;
                primarydark = brown900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Brown900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 233)
            {
                secondaryid = 233;
                secondary = brown900string;
                secondarylight = brown900lightstring;
                secondarydark = brown900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 234)
            {
                primaryid = 234;
                primary = grey50string;
                primarylight = grey50lightstring;
                primarydark = grey50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 234)
            {
                secondaryid = 234;
                secondary = grey50string;
                secondarylight = grey50lightstring;
                secondarydark = grey50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 235)
            {
                primaryid = 235;
                primary = grey100string;
                primarylight = grey100lightstring;
                primarydark = grey100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 235)
            {
                secondaryid = 235;
                secondary = grey100string;
                secondarylight = grey100lightstring;
                secondarydark = grey100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 236)
            {
                primaryid = 236;
                primary = grey200string;
                primarylight = grey200lightstring;
                primarydark = grey200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 236)
            {
                secondaryid = 236;
                secondary = grey200string;
                secondarylight = grey200lightstring;
                secondarydark = grey200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 237)
            {
                primaryid = 237;
                primary = grey300string;
                primarylight = grey300lightstring;
                primarydark = grey300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 237)
            {
                secondaryid = 237;
                secondary = grey300string;
                secondarylight = grey300lightstring;
                secondarydark = grey300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 238)
            {
                primaryid = 238;
                primary = grey400string;
                primarylight = grey400lightstring;
                primarydark = grey400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 238)
            {
                secondaryid = 238;
                secondary = grey400string;
                secondarylight = grey400lightstring;
                secondarydark = grey400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 239)
            {
                primaryid = 239;
                primary = grey500string;
                primarylight = grey500lightstring;
                primarydark = grey500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 239)
            {
                secondaryid = 239;
                secondary = grey500string;
                secondarylight = grey500lightstring;
                secondarydark = grey500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 240)
            {
                primaryid = 240;
                primary = grey600string;
                primarylight = grey600lightstring;
                primarydark = grey600darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 240)
            {
                secondaryid = 240;
                secondary = grey600string;
                secondarylight = grey600lightstring;
                secondarydark = grey600darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 241)
            {
                primaryid = 241;
                primary = grey700string;
                primarylight = grey700lightstring;
                primarydark = grey700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 241)
            {
                secondaryid = 241;
                secondary = grey700string;
                secondarylight = grey700lightstring;
                secondarydark = grey700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 242)
            {
                primaryid = 242;
                primary = grey800string;
                primarylight = grey800lightstring;
                primarydark = grey800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 242)
            {
                secondaryid = 242;
                secondary = grey800string;
                secondarylight = grey800lightstring;
                secondarydark = grey800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 243)
            {
                primaryid = 243;
                primary = grey900string;
                primarylight = grey900lightstring;
                primarydark = grey900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Grey900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 243)
            {
                secondaryid = 243;
                secondary = grey900string;
                secondarylight = grey900lightstring;
                secondarydark = grey900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey50_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 244)
            {
                primaryid = 244;
                primary = bluegrey50string;
                primarylight = bluegrey50lightstring;
                primarydark = bluegrey50darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey50_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 244)
            {
                secondaryid = 244;
                secondary = bluegrey50string;
                secondarylight = bluegrey50lightstring;
                secondarydark = bluegrey50darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey100_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 245)
            {
                primaryid = 245;
                primary = bluegrey100string;
                primarylight = bluegrey100lightstring;
                primarydark = bluegrey100darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey100_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 245)
            {
                secondaryid = 245;
                secondary = bluegrey100string;
                secondarylight = bluegrey100lightstring;
                secondarydark = bluegrey100darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey200_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 246)
            {
                primaryid = 246;
                primary = bluegrey200string;
                primarylight = bluegrey200lightstring;
                primarydark = bluegrey200darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey200_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 246)
            {
                secondaryid = 246;
                secondary = bluegrey200string;
                secondarylight = bluegrey200lightstring;
                secondarydark = bluegrey200darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey300_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 247)
            {
                primaryid = 247;
                primary = bluegrey300string;
                primarylight = bluegrey300lightstring;
                primarydark = bluegrey300darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey300_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 247)
            {
                secondaryid = 247;
                secondary = bluegrey300string;
                secondarylight = bluegrey300lightstring;
                secondarydark = bluegrey300darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey400_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 248)
            {
                primaryid = 248;
                primary = bluegrey400string;
                primarylight = bluegrey400lightstring;
                primarydark = bluegrey400darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey400_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 248)
            {
                secondaryid = 248;
                secondary = bluegrey400string;
                secondarylight = bluegrey400lightstring;
                secondarydark = bluegrey400darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey500_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 249)
            {
                primaryid = 249;
                primary = bluegrey500string;
                primarylight = bluegrey500lightstring;
                primarydark = bluegrey500darkstring;
                textcolor = "#000000";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey500_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 249)
            {
                secondaryid = 249;
                secondary = bluegrey500string;
                secondarylight = bluegrey500lightstring;
                secondarydark = bluegrey500darkstring;
                secondarytextcolor = "#000000";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey600_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 250)
            {
                primaryid = 250;
                primary = bluegrey600string;
                primarylight = bluegrey600lightstring;
                primarydark = bluegrey600darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey600_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 250)
            {
                secondaryid = 250;
                secondary = bluegrey600string;
                secondarylight = bluegrey600lightstring;
                secondarydark = bluegrey600darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey700_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 251)
            {
                primaryid = 251;
                primary = bluegrey700string;
                primarylight = bluegrey700lightstring;
                primarydark = bluegrey700darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey700_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 251)
            {
                secondaryid = 251;
                secondary = bluegrey700string;
                secondarylight = bluegrey700lightstring;
                secondarydark = bluegrey700darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey800_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 252)
            {
                primaryid = 252;
                primary = bluegrey800string;
                primarylight = bluegrey800lightstring;
                primarydark = bluegrey800darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey800_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 252)
            {
                secondaryid = 252;
                secondary = bluegrey800string;
                secondarylight = bluegrey800lightstring;
                secondarydark = bluegrey800darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey900_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (primaryid != 253)
            {
                primaryid = 253;
                primary = bluegrey900string;
                primarylight = bluegrey900lightstring;
                primarydark = bluegrey900darkstring;
                textcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                primaryid = -1;
                primary = "#FFFFFF";
                primarylight = "#FFFFFF";
                primarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Bluegrey900_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (secondaryid != 253)
            {
                secondaryid = 253;
                secondary = bluegrey900string;
                secondarylight = bluegrey900lightstring;
                secondarydark = bluegrey900darkstring;
                secondarytextcolor = "#FFFFFF";
                updatePreview();
            }
            else
            {
                secondaryid = -1;
                secondary = "#FFFFFF";
                secondarylight = "#FFFFFF";
                secondarydark = "#FFFFFF";
                updatePreview();
            }
        }

        private void Button_Click(object sender, MouseButtonEventArgs e)
        {
            primaryid = -1;
            secondaryid = -1;
            updatePreview();
        }

        private void showCheatsheet(object sender, MouseButtonEventArgs e)
        {
            if (csw.IsLoaded)
            {
                csw.Show();
            } 
            else
            {
                csw = new CheatSheetWindow();
                csw.Show();
            }
            
        }

        private void ShowPrimaryColor_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string temp = showPrimaryColor.Text;
            Clipboard.SetText(temp);
            showPrimaryColor.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void ShowPrimaryColor_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            showPrimaryColor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(textcolor));
        }

        private void ShowPrimaryColor_MouseLeave(object sender, MouseEventArgs e)
        {
            showPrimaryColor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(textcolor));
        }

        private void ShowPrimaryLightColor_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string temp = showPrimaryLightColor.Text;
            Clipboard.SetText(temp);
            showPrimaryLightColor.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void ShowPrimaryLightColor_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            showPrimaryLightColor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(textcolor));
        }

        private void ShowPrimaryLightColor_MouseLeave(object sender, MouseEventArgs e)
        {
            showPrimaryLightColor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(textcolor));
        }

        private void ShowPrimaryDarkColor_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string temp = showPrimaryDarkColor.Text;
            Clipboard.SetText(temp);
            showPrimaryDarkColor.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void ShowPrimaryDarkColor_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            showPrimaryDarkColor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(textcolor));
        }

        private void ShowPrimaryDarkColor_MouseLeave(object sender, MouseEventArgs e)
        {
            showPrimaryDarkColor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(textcolor));
        }

        private void ShowSecondaryColor_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string temp = showSecondaryColor.Text;
            Clipboard.SetText(temp);
            showSecondaryColor.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void ShowSecondaryColor_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            showSecondaryColor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondarytextcolor));
        }

        private void ShowSecondaryColor_MouseLeave(object sender, MouseEventArgs e)
        {
            showSecondaryColor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondarytextcolor));
        }

        private void ShowSecondaryLightColor_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string temp = showSecondaryLightColor.Text;
            Clipboard.SetText(temp);
            showSecondaryLightColor.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void ShowSecondaryLightColor_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            showSecondaryLightColor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondarytextcolor));
        }

        private void ShowSecondaryLightColor_MouseLeave(object sender, MouseEventArgs e)
        {
            showSecondaryLightColor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondarytextcolor));
        }

        private void ShowSecondaryDarkColor_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string temp = showSecondaryDarkColor.Text;
            Clipboard.SetText(temp);
            showSecondaryDarkColor.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void ShowSecondaryDarkColor_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            showSecondaryDarkColor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondarytextcolor));
        }

        private void ShowSecondaryDarkColor_MouseLeave(object sender, MouseEventArgs e)
        {
            showSecondaryDarkColor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(secondarytextcolor));
        }
    }
}
