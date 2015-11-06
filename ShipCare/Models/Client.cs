using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShipCare.Models
{
    [Table("Client")]       //회사 테이블
    public class Client
    {
        public int Client_Id { get; set; }          //회사 코드
        public string Client_Name { get; set; }     //회사 이름
        public string Client_Ceo { get; set; }      //대표자 이름
        public string Client_Phone { get; set; }    //대표 전화번호
        public string Client_Fax { get; set; }      //대표 팩스번호
        public string Client_Address { get; set; }  //회사 주소
        public string Client_PostNumber { get; set; }   //우편번호
        public string Client_Remark { get; set; }   //remark
        public string Client_Email { get; set; }    //대표 이메일
        public string Client_HomePage { get; set; } //홈페이지 주소

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Ship_Paticular> Ship_Paticulars { get; set; }
    }
}