namespace Ejercicio2_Exam_DEINT.Formularios
{
    partial class AgregarMantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxIdenNum = new TextBox();
            textBoxCodDes = new TextBox();
            label2 = new Label();
            textBoxCodVeh = new TextBox();
            label3 = new Label();
            textBoxFechaInicio = new TextBox();
            label4 = new Label();
            textBoxFechaFin = new TextBox();
            label5 = new Label();
            textBoxDesc = new TextBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 57);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "IdentNum";
            // 
            // textBoxIdenNum
            // 
            textBoxIdenNum.Location = new Point(117, 87);
            textBoxIdenNum.Name = "textBoxIdenNum";
            textBoxIdenNum.Size = new Size(100, 23);
            textBoxIdenNum.TabIndex = 1;
            textBoxIdenNum.TextChanged += textBoxIdenNum_TextChanged;
            // 
            // textBoxCodDes
            // 
            textBoxCodDes.Location = new Point(117, 164);
            textBoxCodDes.Name = "textBoxCodDes";
            textBoxCodDes.Size = new Size(100, 23);
            textBoxCodDes.TabIndex = 3;
            textBoxCodDes.Validating += textBoxCodDes_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 134);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "CodDesc";
            // 
            // textBoxCodVeh
            // 
            textBoxCodVeh.Location = new Point(117, 247);
            textBoxCodVeh.Name = "textBoxCodVeh";
            textBoxCodVeh.Size = new Size(100, 23);
            textBoxCodVeh.TabIndex = 5;
            textBoxCodVeh.TextChanged += textBoxCodVeh_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 217);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "CodigoVehiculo";
            // 
            // textBoxFechaInicio
            // 
            textBoxFechaInicio.Location = new Point(318, 87);
            textBoxFechaInicio.Name = "textBoxFechaInicio";
            textBoxFechaInicio.Size = new Size(100, 23);
            textBoxFechaInicio.TabIndex = 7;
            textBoxFechaInicio.TextChanged += textBoxFechaInicio_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 57);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "FechaInicio";
            // 
            // textBoxFechaFin
            // 
            textBoxFechaFin.Location = new Point(318, 164);
            textBoxFechaFin.Name = "textBoxFechaFin";
            textBoxFechaFin.Size = new Size(100, 23);
            textBoxFechaFin.TabIndex = 9;
            textBoxFechaFin.TextChanged += textBoxFechaFin_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 134);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "FechaFin";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(318, 247);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(100, 23);
            textBoxDesc.TabIndex = 11;
            textBoxDesc.TextChanged += textBoxDesc_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 217);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 10;
            label6.Text = "Descripcion";
            // 
            // button1
            // 
            button1.Location = new Point(490, 294);
            button1.Name = "button1";
            button1.Size = new Size(141, 56);
            button1.TabIndex = 12;
            button1.Text = "AgregarMantenimiento";
            button1.UseVisualStyleBackColor = true;
            // 
            // AgregarMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxDesc);
            Controls.Add(label6);
            Controls.Add(textBoxFechaFin);
            Controls.Add(label5);
            Controls.Add(textBoxFechaInicio);
            Controls.Add(label4);
            Controls.Add(textBoxCodVeh);
            Controls.Add(label3);
            Controls.Add(textBoxCodDes);
            Controls.Add(label2);
            Controls.Add(textBoxIdenNum);
            Controls.Add(label1);
            Name = "AgregarMantenimiento";
            Text = "AgregarMantenimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxIdenNum;
        private TextBox textBoxCodDes;
        private Label label2;
        private TextBox textBoxCodVeh;
        private Label label3;
        private TextBox textBoxFechaInicio;
        private Label label4;
        private TextBox textBoxFechaFin;
        private Label label5;
        private TextBox textBoxDesc;
        private Label label6;
        private Button button1;
    }
}