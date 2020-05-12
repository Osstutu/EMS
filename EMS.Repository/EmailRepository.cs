using EMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EMS.Repository
{
    class EmailRepository
    {
        private EMSContext _db;
        public EmailRepository()
        {
            _db = new EMSContext();
        }
        public void AddEmail(EmailDetail email)
        {
            _db.EmailDetails.Add(email);
            _db.SaveChanges();
        }

        public void RemoveEmail(int emailID)
        {
            EmailDetail email = _db.EmailDetails.FirstOrDefault(a => a.Mail_ID == emailID);
            if (email != null)
            {
                _db.EmailDetails.Remove(email);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("EmailID doesnt exist");
            }
        }

        public EmailDetail UpdateEmail(EmailDetail email)
        {

            return null;
        }

        public EmailDetail GetEmail(int emailID)
        {

            return _db.EmailDetails.FirstOrDefault(a => a.Mail_ID == emailID);
        }

        public List<EmailDetail> GetMails()
        {
            return _db.EmailDetails.ToList();

        }

    }

}
