#pragma once 
#include<iostream>
#include<string>
#include<cstring>
#include<vector>
#include<sstream>
#include <fstream> 
#include<ctime>
#include <iomanip>  
#include<windows.h>
using namespace std;
using namespace System;
void MarshalString(String ^ s, string& os);

namespace Dr_Hany_billsPrice {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for IbnSena
	/// </summary>

	public ref class IbnSena : public System::Windows::Forms::Form
	{  
	private:
		Object^ f2;
	public:
		IbnSena(Object^ o)
		{
			f2 = o;
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}
		
	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~IbnSena()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::GroupBox^  groupBox1;
	protected:
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::TextBox^  textBox1;
	private: System::Windows::Forms::GroupBox^  groupBox2;
	private: System::Windows::Forms::Button^  button4;
	private: System::Windows::Forms::Button^  button3;
	private: System::Windows::Forms::GroupBox^  groupBox3;
	private: System::Windows::Forms::Button^  button2;
	private: System::Windows::Forms::PictureBox^  pictureBox1;
	private: System::Windows::Forms::Button^  button5;
	private: System::Windows::Forms::Button^  button6;
	private: System::Windows::Forms::TextBox^  textBox2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::GroupBox^  groupBox4;
	private: System::Windows::Forms::TextBox^  textBox3;










	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(IbnSena::typeid));
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->groupBox2 = (gcnew System::Windows::Forms::GroupBox());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->groupBox3 = (gcnew System::Windows::Forms::GroupBox());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->button5 = (gcnew System::Windows::Forms::Button());
			this->button6 = (gcnew System::Windows::Forms::Button());
			this->groupBox4 = (gcnew System::Windows::Forms::GroupBox());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			this->groupBox1->SuspendLayout();
			this->groupBox2->SuspendLayout();
			this->groupBox3->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			this->groupBox4->SuspendLayout();
			this->SuspendLayout();
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->label2);
			this->groupBox1->Controls->Add(this->textBox2);
			this->groupBox1->Controls->Add(this->label3);
			this->groupBox1->Controls->Add(this->button1);
			this->groupBox1->Controls->Add(this->label1);
			this->groupBox1->Controls->Add(this->textBox1);
			this->groupBox1->Location = System::Drawing::Point(12, 12);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(681, 92);
			this->groupBox1->TabIndex = 1;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Information";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(596, 21);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(69, 13);
			this->label2->TabIndex = 6;
			this->label2->Text = L"DD-MM-YYYY";
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(481, 19);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(100, 20);
			this->textBox2->TabIndex = 5;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label3->Location = System::Drawing::Point(352, 21);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(92, 16);
			this->label3->TabIndex = 4;
			this->label3->Text = L"Enter the Date";
			// 
			// button1
			// 
			this->button1->Font = (gcnew System::Drawing::Font(L"Tahoma", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->button1->Location = System::Drawing::Point(161, 46);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(374, 34);
			this->button1->TabIndex = 2;
			this->button1->Text = L"Ok";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &IbnSena::button1_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Tahoma", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(6, 22);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(112, 16);
			this->label1->TabIndex = 1;
			this->label1->Text = L"Enter the bill price";
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(136, 21);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(97, 20);
			this->textBox1->TabIndex = 0;
			// 
			// groupBox2
			// 
			this->groupBox2->Controls->Add(this->button4);
			this->groupBox2->Controls->Add(this->button3);
			this->groupBox2->Font = (gcnew System::Drawing::Font(L"Tahoma", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->groupBox2->Location = System::Drawing::Point(12, 110);
			this->groupBox2->Name = L"groupBox2";
			this->groupBox2->Size = System::Drawing::Size(260, 89);
			this->groupBox2->TabIndex = 2;
			this->groupBox2->TabStop = false;
			this->groupBox2->Text = L"Show the Total bill price";
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(33, 57);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(200, 26);
			this->button4->TabIndex = 1;
			this->button4->Text = L"View List of price";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &IbnSena::button4_Click);
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(33, 20);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(200, 31);
			this->button3->TabIndex = 0;
			this->button3->Text = L"View Total price";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &IbnSena::button3_Click);
			// 
			// groupBox3
			// 
			this->groupBox3->Controls->Add(this->button2);
			this->groupBox3->Location = System::Drawing::Point(12, 198);
			this->groupBox3->Name = L"groupBox3";
			this->groupBox3->Size = System::Drawing::Size(260, 57);
			this->groupBox3->TabIndex = 3;
			this->groupBox3->TabStop = false;
			this->groupBox3->Text = L"Start New Month";
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(33, 20);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(200, 23);
			this->button2->TabIndex = 0;
			this->button2->Text = L"Start New Month";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &IbnSena::button2_Click);
			// 
			// pictureBox1
			// 
			this->pictureBox1->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox1.Image")));
			this->pictureBox1->Location = System::Drawing::Point(12, 261);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(260, 128);
			this->pictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox1->TabIndex = 4;
			this->pictureBox1->TabStop = false;
			// 
			// button5
			// 
			this->button5->BackColor = System::Drawing::Color::Lime;
			this->button5->Location = System::Drawing::Point(12, 412);
			this->button5->Name = L"button5";
			this->button5->Size = System::Drawing::Size(260, 32);
			this->button5->TabIndex = 5;
			this->button5->Text = L"Home";
			this->button5->UseVisualStyleBackColor = false;
			this->button5->Click += gcnew System::EventHandler(this, &IbnSena::button5_Click);
			// 
			// button6
			// 
			this->button6->BackColor = System::Drawing::Color::Fuchsia;
			this->button6->Location = System::Drawing::Point(12, 450);
			this->button6->Name = L"button6";
			this->button6->Size = System::Drawing::Size(260, 34);
			this->button6->TabIndex = 6;
			this->button6->Text = L"Exit";
			this->button6->UseVisualStyleBackColor = false;
			this->button6->Click += gcnew System::EventHandler(this, &IbnSena::button6_Click);
			// 
			// groupBox4
			// 
			this->groupBox4->Controls->Add(this->textBox3);
			this->groupBox4->Font = (gcnew System::Drawing::Font(L"Tahoma", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->groupBox4->Location = System::Drawing::Point(287, 110);
			this->groupBox4->Name = L"groupBox4";
			this->groupBox4->Size = System::Drawing::Size(406, 379);
			this->groupBox4->TabIndex = 7;
			this->groupBox4->TabStop = false;
			this->groupBox4->Text = L"bills List Information";
			// 
			// textBox3
			// 
			this->textBox3->Location = System::Drawing::Point(16, 26);
			this->textBox3->Multiline = true;
			this->textBox3->Name = L"textBox3";
			this->textBox3->Size = System::Drawing::Size(374, 332);
			this->textBox3->TabIndex = 0;
			// 
			// IbnSena
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(705, 501);
			this->Controls->Add(this->groupBox4);
			this->Controls->Add(this->button6);
			this->Controls->Add(this->button5);
			this->Controls->Add(this->pictureBox1);
			this->Controls->Add(this->groupBox3);
			this->Controls->Add(this->groupBox2);
			this->Controls->Add(this->groupBox1);
			this->Name = L"IbnSena";
			this->Text = L"IBN SINA Company";
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			this->groupBox2->ResumeLayout(false);
			this->groupBox3->ResumeLayout(false);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			this->groupBox4->ResumeLayout(false);
			this->groupBox4->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void button6_Click(System::Object^  sender, System::EventArgs^  e) {
			 Application::Exit();
	}
			 int numberOfBill;
private: System::Void button5_Click(System::Object^  sender, System::EventArgs^  e) { 
			 //Dr_Hany_billsPrice::Home^ f2 = gcnew Home();
			 //f2->Show();
			 //this->Hide();
			 safe_cast<Form^>(f2)->Show();
			 this->Hide();
}
private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {  
			 String^ text = textBox1->Text;
			 string billPrice = "";
			 MarshalString(text, billPrice);
			  
			 String^ text2 = textBox2->Text;
			 string buffer = "";
			 MarshalString(text2, buffer);


			 ifstream read;
			 string buff; 
			 vector<string>vect;
			 vect.clear();
			 read.open("num.txt");
			 if (read.fail()){
				 MessageBox::Show("There is errors in your operating system");
				 safe_cast<Form^>(f2)->Show();
				 this->Hide();
			 }

			 while (!read.eof())
			 {
				 read>> buff;
				 vect.push_back(buff);
			 } 
			 read.close();
			 numberOfBill = 1;
			 if (vect.size()>1)
			 { 
				 string x = vect[vect.size() - 4];
				 stringstream xx;
				 xx << x;
				 int u;
				 xx >> u;
				 numberOfBill = u +1;
			 }
			  

			 ofstream outfile1;
			 outfile1.open("num.txt", ios::app);
			 outfile1 << setw(4)<<numberOfBill;
			 outfile1 << setw(18) << billPrice ;
			 outfile1 << setw(22) << buffer <<endl;
			 MessageBox::Show("All Done , Every thing is ok"); 
			 outfile1.close();
}
private: System::Void button3_Click(System::Object^  sender, System::EventArgs^  e) {
			 
			 ifstream r;
			 string buff; 
			 vector<string>vec;
			 r.open("num.txt");
			 if (r.fail()){
				 MessageBox::Show("There is errors in your operating system");
				 safe_cast<Form^>(f2)->Show();
				 this->Hide();
			 }
			 while (!r.eof())
			 {
				 r>>buff;
				 vec.push_back(buff);
			 }
			 if (vec.size()==0)
			 {
				 MessageBox::Show("There is no Bills");
			 }
			 else
			 {
				 double num, sum;
				 sum = 0;
				 int xx = vec.size();
				 for (int i = 1; i < xx; i += 3)
				 {
					 string x = vec[i];
					 num = atof(x.c_str());
					 sum += num;
				 }
				 String ^s = System::Convert::ToString(sum);
				 MessageBox::Show("your total price = "+s);
				 
			 }
			 r.close();
}
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
			 ofstream readd;
			 readd.open("num.txt",ios::trunc);
			 MessageBox::Show("You Now Starting New month");
			 readd.close();
}
private: System::Void Home_FormClosing(System::Object^  sender, System::Windows::Forms::FormClosingEventArgs^  e) {
			 if (MessageBox::Show("Sure Want To Exit?", "Files", MessageBoxButtons::YesNo, MessageBoxIcon::Question) == System::Windows::Forms::DialogResult::Yes)
			 {
				 Application::Exit();
			 }
			 else
				 e->Cancel = true;
} 
private: System::Void button4_Click(System::Object^  sender, System::EventArgs^  e) {


			 textBox3->Text = System::IO::File::ReadAllText("num.txt");
			  
}
private: System::Void listView1_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) {
			 
}
private: System::Void listView1_SelectedIndexChanged_1(System::Object^  sender, System::EventArgs^  e) {
}
};
}
