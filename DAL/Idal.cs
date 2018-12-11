using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace DAL
{
    public interface Idal
    {
        void add_tester(Tester tester );
        void delete_tester(Tester tester);
        void updat_tester(Tester tester);

        void add_trainee(Trainee trainee);
        void delete_trainee(Trainee trainee);
        void updat_trainee(Trainee trainee);

        void add_test(Test test);
        void updat_test(Test test);

        string testers();
        string trainees();
        string tests();
    }
}
