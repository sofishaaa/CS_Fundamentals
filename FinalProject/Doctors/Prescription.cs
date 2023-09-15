using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Doctors
{
    [Serializable]
    public class Prescription
    {
        private string medicine;
        private DateTime issueDate;
        private DateTime expirationDate;

        [XmlAttribute]
        public string Medicine
        {
            get { return medicine; }
            set { medicine = value; }
        }

        [XmlAttribute]
        public DateTime IssueDate
        {
            get { return issueDate; }
            set { issueDate = value; }
        }

        [XmlAttribute]
        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        public Prescription()
        {
            
        }

        public Prescription(string medicine, DateTime issueDate, DateTime expirationDate)
        {
            this.medicine = medicine;
            this.issueDate = issueDate;
            this.expirationDate = expirationDate;
        }

        public bool IsExpired()
        {
            DateTime currentDate = DateTime.Now;
            return currentDate > expirationDate;
        }
    }
}

