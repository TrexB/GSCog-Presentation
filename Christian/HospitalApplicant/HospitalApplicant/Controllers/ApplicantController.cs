using HospitalApplicant.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApplicant.Controllers
{
    [ApiController]
    public class ApplicantController : Controller
    {
        [HttpPost]
        [Route("Add_Applicant")]
        public void Add_Applicant(string DN, string DEP, int Floor, int SSN)
        {
            List<ApplicantsModel> Doctors = new();
            var connection = "Data Source=Chris-PC;Initial Catalog=MONGODB;Integrated Security=True";
            using (SqlConnection sqlConnection = new(connection))
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "Add_Applicant",
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                sqlConnection.Open();
                cmd.Parameters.Add("@DN", SqlDbType.VarChar).Value = DN;
                cmd.Parameters.Add("@DEP", SqlDbType.VarChar).Value = DEP;
                cmd.Parameters.Add("@Floor", SqlDbType.Int).Value = Floor;
                cmd.Parameters.Add("@SSN", SqlDbType.Int).Value = SSN;
                cmd.ExecuteNonQuery();
            }
        }

    }
}
