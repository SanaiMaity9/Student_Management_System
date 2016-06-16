using System;
using System.IO;

namespace StudentManagementSystem
{
     public class PersonalDetails
    {
        private string Name { get; set; }
		private string[] Class = new string[3]; 
		private  string State { get; set; }
		private string PhoneNo { get; set; }
        private string[] Subject = new string[10];
        private  string EmailId { get; set; }
        
       public void  Details(string name, string[] className, string state, string phoneNo, string[] subject, string emailId)
       {
           Array.Clear(Subject,0,Subject.Length);
           Name = name;
           Class = className;
           State = state;
           PhoneNo = phoneNo;
           Subject = subject;
           EmailId = emailId;
       }
       
       public String GetTeacher(){
			int i = 0;
			string format;
			format = Name + "\t";
			foreach(var item in Class)
			{
				if(item != null)
				{
				    format += Class[i] + "\t";	
					i++;
				}
			}
			format	+=  State + "\t" + PhoneNo + "\t" + Subject[0] + "\t" + EmailId;
			return format;
		}
        
       public string GetStudent()
       {
           int i = 0;
			string format;
			format = Name + "\t" + Class[0] + "\t" + State + "\t" + PhoneNo + "\t" ;
            foreach(var item in Subject)
			{
				if(item != null)
				{
				    format += Subject[i] + "\t";	
					i++;
				}
			}
            format	+=  EmailId;
            
			return format;
           
       }
       
       public Array GetClass()
       {
           return Class;
       }
       public Array GetSubject()
       {
           return Subject;
       }
     
    }
}