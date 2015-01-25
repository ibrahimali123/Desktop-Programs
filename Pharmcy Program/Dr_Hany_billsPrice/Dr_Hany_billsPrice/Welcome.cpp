#include "Welcome.h" 
#include<iostream>
#include<string>

using namespace std;
using namespace System;
using namespace System::Windows::Forms;
void MarshalString(String ^ s, string& os) {
	using namespace Runtime::InteropServices;
	const char* chars =
		(const char*)(Marshal::StringToHGlobalAnsi(s)).ToPointer();
	os = chars;
	Marshal::FreeHGlobal(IntPtr((void*)chars));
}
[STAThread]
void Main(array<String^>^ args)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);

	Dr_Hany_billsPrice::Welcome form;
	Application::Run(%form);
}
