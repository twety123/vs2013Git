using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace firstMVC.Models
{
    //用户图书model层，数据格式
    public class GustBook
    {
        public int Id { get; set; }//id
        public string 姓名 { get; set; }//姓名
        public string Email { get; set; }//电子邮箱
        public string 内容 { get; set; }//内容

    }
}