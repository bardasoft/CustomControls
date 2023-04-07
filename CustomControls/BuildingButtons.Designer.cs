
namespace CustomControls
{
    partial class BuildingButtons
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectAll
            // 
            this.selectAll.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.selectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAll.Location = new System.Drawing.Point(10, 10);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(154, 35);
            this.selectAll.TabIndex = 0;
            this.selectAll.Text = "전체";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // BuildingButtons
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(80)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.selectAll);
            this.Font = new System.Drawing.Font("Noto Sans KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "BuildingButtons";
            this.Size = new System.Drawing.Size(173, 55);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectAll;
    }
}
