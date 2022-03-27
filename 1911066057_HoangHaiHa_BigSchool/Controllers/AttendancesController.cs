using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _1911066057_HoangHaiHa_BigSchool.DTOs;
using _1911066057_HoangHaiHa_BigSchool.Models;
using Microsoft.AspNet.Identity;

namespace _1911066057_HoangHaiHa_BigSchool.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.Courseid == attendanceDto.Courseid))
                return BadRequest("The Attendance already exists");
            var attendance = new Attendance
            {
                Courseid = attendanceDto.Courseid,
                AttendeeId = userId
            };

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
