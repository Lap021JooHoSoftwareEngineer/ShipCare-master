using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCare.Models
{
    [Table("User")]    //사용자 테이블
    public class User
    {
        public int Client_Id { get; set; }

        public string User_Email { get; set; }      //이메일
        public string User_Name { get; set; }       //이름
        public string User_Phone { get; set; }      //전화번호
        public string User_CellPhone { get; set; }  //휴대폰 번호
        public string User_Position { get; set; }   //직책
        public string User_Passworld { get; set; }  //계정비밀번호
        public int User_Level { get; set; }         //권한레벨
        public byte[] User_Photo { get; set; }      //사진
        public virtual Client Client { get; set; }
    }
}
