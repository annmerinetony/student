using System.Linq;
using CRUD_Operations.Models;
using Microsoft.AspNetCore.Mvc;
namespace AdminPanelTutorial
{
    public class StudentController : Controller
    {
        MyDbContext db = new MyDbContext();
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateStudent(Student Student){
            db.Students.Add(Student);
            db.SaveChanges();
            return RedirectToAction("Index", "Student");
        }
        [HttpPost]
        public bool Delete(int id){
            try
            {
                Student Student = db.Students.Where(s => s.Id == id).First();
                db.Students.Remove(Student);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
            
        }
        public ActionResult Update(int id){
            return View(db.Students.Where(s => s.Id == id).First());
        }
        [HttpPost]
        public ActionResult UpdateStudent(Student Student){
            Student d = db.Students.Where(s => s.Id == Student.Id).First();
            d.Name = Student.Name;
            d.Phone = Student.Phone;
            d.Gender = Student.Gender;
            d.Email= Student.Email;
            d.Dob= Student.Dob;
            db.SaveChanges();
            return RedirectToAction("Index", "Student");
        }
    }
}