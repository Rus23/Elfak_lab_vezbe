using System.Collections.Generic;
using System.Linq;

namespace OOP.EF.Data
{
    public static class Common
    {
        public static List<StudentCustom> GetStudenti()
        {
            using (OOPEntities context = new OOPEntities())
            {
                List<StudentCustom> q = context.students.
                               Select(x => new StudentCustom
                               {

                                   Id = x.student_id,
                                   ZaPrikaz = x.index + " - " + x.ime + " " + x.prezime
                               })
                               .OrderBy(x => x.Id)
                               .ToList();

                return q;
            }
        }

        public static List<Telefon> GetTelefon(long studentId)
        {
            using (OOPEntities context = new OOPEntities())
            {
                return context.student_telefon
                              .Where(x => x.student_id == studentId)
                              .OrderBy(x => x.telefon)
                              .Select(x => new Telefon
                              {
                                  student_telefon_id = x.student_telefon_id,
                                  telefon = x.telefon
                              })
                              .ToList<Telefon>();
            }
        }

        public static List<IspitCustom> GetIspitiAll(long studentId)
        {
            using (OOPEntities context = new OOPEntities())
            {
                var q = context.student_ispit
                               .Where(x => x.student_id == studentId)
                               .Select(x => new IspitCustom
                               {
                                   student_ispit_id = x.student_ispit_id,
                                   ispit_id = x.ispit_id,
                                   sifra = x.ispit.sifra,
                                   naziv = x.ispit.naziv
                               })
                               .OrderBy(x => x.sifra)
                               .ToList<IspitCustom>();

                return q;
            }
        }

        public static void AddNewStudent(string ime, string prezime, int index)
        {
            using (OOPEntities context = new OOPEntities())
            {
                student s = new student();
                s.ime = ime;
                s.prezime = prezime;
                s.index = index;

                context.students.Add(s);
                context.SaveChanges();
            }
        }

        public static void UpdateStudent(string ime, string prezime, int index, long studentId)
        {
            using (OOPEntities context = new OOPEntities())
            {
                student s = context.students
                                   .Where(x => x.student_id == studentId)
                                   .FirstOrDefault();

                if (s == null)
                    return;

                s.ime = ime;
                s.prezime = prezime;
                s.index = index;

                context.SaveChanges();
            }
        }

        public static student GetStudent(long studentId)
        {
            using (OOPEntities context = new OOPEntities())
            {
                student s = context.students
                                   .Where(x => x.student_id == studentId)
                                   .FirstOrDefault();

                return s;
            }
        }

        public static student GetStudent(long studentId, OOPEntities context)
        {

            student s = context.students
                               .Where(x => x.student_id == studentId)
                               .FirstOrDefault();

            return s;

        }

        public static void DeleteStudent(long studnetId)
        {
            using (OOPEntities context = new OOPEntities())
            {
                student s = context.students
                            .Where(x => x.student_id == studnetId)
                            .FirstOrDefault();
                if (s == null)
                    return;

                List<student_telefon> telefoni = context.student_telefon
                                                        .Where(x => x.student_id == studnetId)
                                                        .ToList();

                if (telefoni != null)
                    context.student_telefon.RemoveRange(telefoni);

                List<student_ispit> ispiti = context.student_ispit
                                                    .Where(x => x.student_id == studnetId)
                                                    .ToList();

                if (ispiti != null)
                    context.student_ispit.RemoveRange(ispiti);

                context.students.Remove(s);

                context.SaveChanges();
            }
        }

        public static void AddNewTelefon(long studentId, string telefon)
        {
            using (OOPEntities context = new OOPEntities())
            {
                student s = GetStudent(studentId, context);

                student_telefon t = new student_telefon();
                t.student = s;
                t.telefon = telefon;

                context.student_telefon.Add(t);
                context.SaveChanges();
            }
        }

        public static void DeleteTelefon(long studentTelefonId)
        {
            using (OOPEntities context = new OOPEntities())
            {
                student_telefon t = context.student_telefon
                                           .Where(x => x.student_telefon_id == studentTelefonId)
                                           .FirstOrDefault();
                if (t == null)
                    return;

                context.student_telefon.Remove(t);
                context.SaveChanges();
            }
        }

        public static void AddNewIspit(string sifra, string naziv)
        {
            using (OOPEntities context = new OOPEntities())
            {
                ispit i = new ispit();
                i.naziv = naziv;
                i.sifra = sifra;

                context.ispits.Add(i);
                context.SaveChanges();
            }
        }

        public static void DeleteIspit(int ispitId)
        {
            using (OOPEntities context = new OOPEntities())
            {
                ispit i = context.ispits.Where(x => x.ispit_id == ispitId).FirstOrDefault();

                if (i == null)
                    return;
                context.ispits.Remove(i);
                context.SaveChanges();
            }
        }

        public static List<ispit> GetIspiti()
        {
            using (OOPEntities context = new OOPEntities())
            {
                List<ispit> i = context.ispits.Select(x => x).ToList();
                return i;
            }
        }

        public static void DeleteStudentIspit(long studentIspitId)
        {
            using (OOPEntities context = new OOPEntities())
            {
                student_ispit s = context.student_ispit
                                         .Where(x => x.student_ispit_id == studentIspitId)
                                         .FirstOrDefault();

                if (s == null)
                    return;

                context.student_ispit.Remove(s);
                context.SaveChanges();
            }
        }

        public static void AddStudentIspit(long studentId, int ispitId)
        {
            using (OOPEntities context = new OOPEntities())
            {
                student_ispit si = new student_ispit();
                si.student = GetStudent(studentId, context);
                si.ispit = context.ispits.Where(x => x.ispit_id == ispitId).FirstOrDefault();

                context.student_ispit.Add(si);
                context.SaveChanges();
            }
        }

        public static List<ispit> GetIspiti(long studentId)
        {
            using (OOPEntities context = new OOPEntities())
            {
                List<ispit> i = context.ispits
                                       .Where(x => !context.student_ispit.Any(y => y.ispit_id == x.ispit_id
                                                                               && y.student_id == studentId))
                                       .Select(x => x)
                                       .ToList();

                return i;
            }
        }

    }
}