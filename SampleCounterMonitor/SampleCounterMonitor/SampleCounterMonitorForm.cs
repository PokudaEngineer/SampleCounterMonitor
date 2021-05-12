using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCounterMonitor {
    public partial class SampleCounterMonitorForm : Form {

        /// <summary>ビットデバイスON</summary>
        private const short ON = 1;
        /// <summary>ビットデバイスOFF</summary>
        private const short OFF = 0;
        /// <summary>MX Componentメソッド正常終了</summary>
        private const int SUCCESS = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SampleCounterMonitorForm() {
            InitializeComponent();
        }

        /// <summary>
        /// 「モニタ開始」ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e) {
            int logicalStationNumber;		//ActUtlType用の論理局番

            //モニタ表示の消去
            ClearDisplay();

            //Open関数処理
            try {
                logicalStationNumber = int.Parse(this.LogicalStationNumberText.Text);

                //論理局番の設定
                ActUtlType.ActLogicalStationNumber = logicalStationNumber;
                //パスワードの設定
                ActUtlType.ActPassword = "";

                //Open関数処理の実行
                int ret = ActUtlType.Open();
                ShowMessage(ret);
                if (ret != SUCCESS) {
                    return;
                }
                //Openが成功した場合、LogicalStationNumberテキストボックスを無効にする。
                this.LogicalStationNumberText.Enabled = false;

                int cpuCode;
                string cpuName;
                ret = ActUtlType.GetCpuType(out cpuName, out cpuCode);
                ShowMessage(ret);
                if (ret != SUCCESS) {
                    return;
                }
                CPUTypeText.Text = cpuName;
                this.C0Text.Text = ReadC0Value();
                this.Y3Text.Text = ReadY3Value();

                this.Timer.Enabled = true;

            } catch (Exception exception) {
                MessageBox.Show(exception.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 「COUNT UP」ボタンクリック(X3をON->OFF)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountUpButton_Click(object sender, EventArgs e) {
            //X3デバイスをON
            int ret = ActUtlType.SetDevice2("X3", ON);
            ShowMessage(ret);
            if (ret != SUCCESS) {
                return;
            }
            Thread.Sleep(500);
            //X3デバイスをOFF
            ret = ActUtlType.SetDevice2("X3", OFF);
            ShowMessage(ret);
            if (ret != SUCCESS) {
                return;
            }

            this.C0Text.Text = ReadC0Value();
            this.Y3Text.Text = ReadY3Value();
        }

        /// <summary>
        /// 「RESET」ボタンクリック(X1をON->OFF)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e) {
            //X1デバイスをON
            int ret = ActUtlType.SetDevice2("X1", ON);
            Thread.Sleep(500);
            //X1デバイスをOFF
            ret = ActUtlType.SetDevice2("X1", OFF);

            this.C0Text.Text = ReadC0Value();
            this.Y3Text.Text = ReadY3Value();
        }

        /// <summary>
        /// C0デバイスの値を書き換える
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WriteC0Button_Click(object sender, EventArgs e) {
            //C0デバイスを変更
            short val = short.Parse(this.C0Text.Text);
            int ret = ActUtlType.SetDevice2("C0", val);
        }

        /// <summary>
        /// モニタ終了ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndButton_Click(object sender, EventArgs e) {
            int ret;	//コントロールのメソッドの戻り値

            //結果表示の消去
            ClearDisplay();

            try {
                //Close関数処理の実行
                ret = ActUtlType.Close();
                ShowMessage(ret);
                if (ret != SUCCESS) {
                    return;
                }
                //Closeが成功した場合、LogicalStationNumberテキストボックスを有効にする。
                LogicalStationNumberText.Enabled = true;
                this.LogicalStationNumberText.Text = "";
                CPUTypeText.Text = "";
                this.C0Text.Text = "";
                this.Y3Text.Text = "";

                this.Timer.Enabled = false;
            } catch (Exception exception) {
                MessageBox.Show(exception.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// エラーコードに該当するメッセージを表示
        /// </summary>
        /// <param name="returnCode"></param>
        private void ShowMessage(int returnCode) {
            //コントロールのメソッドの戻り値の表示(8桁の16進数)
            string returnText = String.Format("0x{0:x8}", returnCode);
            string msg;
            int ret = 0;
            ret = ActSupportMsg.GetErrorMessage(returnCode, out msg);
            if (ret == SUCCESS) {
                this.MessageText.Text = returnText + ":" + msg;
            } else {
                this.MessageText.Text = "メッセージ取得に失敗しました。";
            }
        }

        /// <summary>
        /// 監視ログのデータをクリア
        /// </summary>
        private void ClearDisplay() {
            this.LoggingList.Items.Clear();
        }

        /// <summary>
        /// C0デバイス値を取得
        /// </summary>
        /// <returns>デバイス値</returns>
        private string ReadC0Value() {
            string value = "";
            short deviceValue;

            //C0(CN0)デバイスの値を取得
            int ret = ActUtlType.GetDevice2("C0", out deviceValue);
            //int ret = ActUtlType.ReadDeviceRandom2("C0", 1, out deviceValue);
            ShowMessage(ret);
            if (ret != SUCCESS) {
                return value;
            }
            value = deviceValue.ToString();
            return value;
        }

        /// <summary>
        /// Y3デバイス値を取得
        /// </summary>
        /// <returns>デバイス値</returns>
        private string ReadY3Value() {
            string value = "";
            short deviceValue;

            //Y3デバイスの値を取得
            int ret = ActUtlType.GetDevice2("Y3", out deviceValue);
            ShowMessage(ret);
            if (ret != SUCCESS) {
                return value;
            }
            value = deviceValue.ToString();
            return value;
        }

        /// <summary>
        /// 1秒毎にポーリングして、デバイス値を表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e) {
            var sb = new StringBuilder();
            sb.Append("[");
            sb.Append(GetPLCClockData());
            sb.Append("],");
            sb.Append("C0=" + ReadC0Value());
            sb.Append(",Y3=" + ReadY3Value());
            this.LoggingList.Items.Insert(0, sb.ToString());
        }

        /// <summary>
        /// PLCの時刻データを取得
        /// </summary>
        /// <returns>時刻データ文字列</returns>
        private string GetPLCClockData() {
            short year;
            short month;
            short day;
            short dayOfWeek;
            short hour;
            short minute;
            short second;
            ActUtlType.GetClockData(out year, out month, out day, out dayOfWeek, out hour, out minute, out second);

            return year.ToString("00") + "/" + month.ToString("00") + "/" + day.ToString("00") + " " + 
                hour.ToString("00") + ":" + minute.ToString("00") + ":" + second.ToString("00");
        }
    }
}
