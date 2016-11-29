using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Security.Cryptography;

namespace BUS
{
    public class AuthenticationBUS
    {
        private string GetMd5Hash(MD5 md5, string input)
        {
            byte[] result = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public void verifyAccount(NhanVien nv)
        {
            //Mã hoá mật khẩu thành mã băm MD5
            MD5 md5 = MD5.Create();
            nv.MatKhau = GetMd5Hash(md5, nv.MatKhau);

            AuthenticationDAO dao = new AuthenticationDAO();
            dao.verifyAccount(nv);
        }
    }
}
