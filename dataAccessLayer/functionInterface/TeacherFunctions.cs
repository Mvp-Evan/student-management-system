using System;
using dataAccessLayer.entity;

namespace dataAccessLayer.functionInterface
{
    public class TeacherFunctions : ITeacherFunctions
    {
        public bool InsertTeacher(TeacherEntity teacher)
        {
            using (var db = new EntityContext())
            {
                db.Add(teacher);
                db.SaveChanges();
            }

            return true;
        }

        public TeacherEntity SelectTeacherById(int id)
        {
            TeacherEntity teacher;
            using (var db = new EntityContext())
            {
                teacher = db.teachers.Find(id);
            }

            return teacher;
        }
        
        public bool DeleteTeacherById(int id)
        {
            using (var db = new EntityContext())
            {
                TeacherEntity teacher = db.teachers.Find(id);
                db.Remove(teacher);
                db.SaveChanges();
            }

            return true;
        }
    }
}