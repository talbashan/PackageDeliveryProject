using System;
using DAL;
using BE;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using Accord.MachineLearning;

namespace BLL
{


    public class BLLImp
    {
        DalImp dalImp;

        public BLLImp()
        {
            dalImp = new DalImp();
        }

        public void AddDistrubutor(Distributors distrubutor)
        {
            String error = "";
            if (DateTime.Now.Year - distrubutor.distributors_date_of_birth.Year < 18)
            {
                error += "את.ה צעיר.ה מידי בכדי לעבוד כמחלק חבילות מזון";
                error += "\n";
            }
            if (distrubutor.distributors_work_days.amountOfDays() < 3)
            {
                error += "עלייך לסמן לפחות 3 ימי עבודה שבועים";
                error += "\n";
            }
            if (dalImp.addressCalculations.IsRealAdrressApi(distrubutor.distributors_address) == false)
            {
                error += "כתובת לא תקינה";
                error += "\n";
            }
            if (error == "")
            {
                try
                {
                    dalImp.AddDistrubutor(distrubutor);
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
            else
            {
                throw new Exception(error);
            }
        }

        public void AddRecipients(Recipients recipients)
        {
            String error = "";
            if (recipients.recipients_status == status.קשיש)
            {
                if (DateTime.Now.Year - recipients.recipients_date_of_birth.Year < 60)
                {
                    error += "ישנה חוסר התאמה בין גילך לסטטוס אותו הזנת";
                    error += "\n";
                }
            }
            if (recipients.recipients_package.numOfProducts() < 5)
            {
                error += "חבילתך לא מכילה את המספר המינימלי של פרטים שיש לבחור";
                error += "\n";
            }
            if (DateTime.Compare(recipients.recipients_package.package_finish_date, DateTime.Today) < 0)
            {
                error += "תוקף המנוי שלך חלף, אינך זכאי לקבל חבילות נוספות";
                error += "\n";
            }
            if (DateTime.Compare(recipients.recipients_package.package_start_date, recipients.recipients_package.package_finish_date) > 0)
            {
                error += "שגיאה בזנת תאריך התחלה ותאריך סיום";
                error += "\n";
            }
            if (dalImp.addressCalculations.IsRealAdrressApi(recipients.recipients_address) == false)
            {
                error += "כתובת לא תקינה";
                error += "\n";
            }
            if (error == "")
            {
                try
                {
                    dalImp.AddRecipients(recipients);
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }

            else
            {
                throw new Exception(error);
            }
        }

        public void AddWorkSchedule(WorkSchedule workSchedule)
        {
            String error = "";
            if (DateTime.Compare(workSchedule.workSchedule_date, DateTime.Today) > 0)
            {
                error += "התאריך שהזנת שגוי, תאריך עתידי טרם ניתן לקבוע סידור עבודה";
            }
            if (selectDistributors(d => d.distributors_id == workSchedule.distributor_id).Count == 0)
            {
                error += "תעודת זהות של מחלק לא קיימת במערכת";

            }
            if (error == "")
            {
                try
                {
                    dalImp.AddWorkSchedule(workSchedule);
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }

            else
            {
                throw new Exception(error);
            }
        }

        public void AddAdmin(Admin admin)
        {
            List<Admin> list = selectAdmins();
            if (list.Count != 0)
            {
                throw new Exception("ניתן ליצור רק אדמין אחד במערכת");
            }
            try
            {
                dalImp.AddAdmin(admin);
            }
            catch (Exception exp)
            {
                throw exp;
            }

        }

        public void UpdateDistributors(Distributors distributors)
        {
            String error = "";
            if (dalImp.addressCalculations.IsRealAdrressApi(distributors.distributors_address) == false)
            {
                error += "כתובת לא תקינה";
                error += "\n";
            }
            if (DateTime.Now.Year - distributors.distributors_date_of_birth.Year < 18)
            {
                error += "את.ה צעיר.ה מידי בכדי לעבוד כמחלק חבילות מזון";
                error += "\n";
            }
            if (distributors.distributors_work_days.amountOfDays() < 3)
            {
                error += "עלייך לסמן לפחות 3 ימי עבודה שבועים";
                error += "\n";
            }
            if (error == "")
            {
                try
                {
                    dalImp.UpdateDistributors(distributors);
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
            else
            {
                throw new Exception(error);
            }
        }

        public void UpdateRecipients(Recipients recipients)
        {
            String error = "";
            if (recipients.recipients_status == status.קשיש)
            {
                if (DateTime.Now.Year - recipients.recipients_date_of_birth.Year < 60)
                {
                    error += "ישנה חוסר התאמה בין גילך לסטטוס אותו הזנת";
                    error += "\n";
                }
            }
            if (recipients.recipients_package.numOfProducts() < 5)
            {
                error += "חבילתך לא מכילה את המספר המינימלי של פרטים שיש לבחור";
                error += "\n";
            }
                if (DateTime.Compare(recipients.recipients_package.package_finish_date, DateTime.Today) < 0)
            {
                error += "תוקף המנוי שלך חלף, אינך זכאי לקבל חבילות נוספות";
                error += "\n";
            }
            if (DateTime.Compare(recipients.recipients_package.package_start_date, recipients.recipients_package.package_finish_date) > 0)
            {
                error += "שגיאה בזנת תאריך התחלה ותאריך סיום";
                error += "\n";
            }
            if (dalImp.addressCalculations.IsRealAdrressApi(recipients.recipients_address) == false)
            {
                error += "כתובת לא תקינה";
                error += "\n";
            }
            if (error == "")
            {
                try
                {
                    dalImp.UpdateRecipients(recipients);
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }

            else
            {
                throw new Exception(error);
            }
        }

        public void UpdateWorkSchedule(WorkSchedule workSchedule)
        {
            String error = "";
            if (DateTime.Compare(workSchedule.workSchedule_date, DateTime.Today) > 0)
            {
                error += "התאריך שהזנת שגוי, תאריך עתידי טרם נקבע סידור עבודה";
            }
            if (selectDistributors(d => d.distributors_id == workSchedule.distributor_id).Count == 0)
            {
                error += "תעודת זהות של מחלק לא קיימת במערכת";

            }
            if (error == "")
            {
                try
                {
                    dalImp.UpdateWorkSchedule(workSchedule);
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }

            else
            {
                throw new Exception(error);
            }
        }

        public void UpdateAdmin(Admin admin)
        {
            try
            {
                dalImp.UpdateAdmin(admin);
            }
            catch (Exception exp)
            {
                throw exp;
            }

        }

        public void DeleteDistributors(Distributors distributors)
        {
            try
            {
                dalImp.DeleteDistributors(distributors);
            }
            catch (Exception exp)
            {
                throw exp;
            }

        }

        public void DeleteRecipients(Recipients recipients)
        {
            try
            {
                dalImp.DeleteRecipients(recipients);
            }
            catch (Exception exp)
            {
                throw exp;
            }

        }

        public void DeleteAdmin(Admin admin)
        {
            try
            {
                dalImp.DeleteAdmin(admin);
            }
            catch (Exception exp)
            {
                throw exp;
            }

        }

        public List<Distributors> selectDistributors(Func<Distributors, bool> predicat = null)
        {
            return dalImp.selectDistributors(predicat);
        }

        public List<Recipients> selectRecipients(Func<Recipients, bool> predicat = null)
        {
            return dalImp.selectRecipients(predicat);
        }

        public List<Recipients> selectRecipientsById(string ids)
        {
            List<Recipients> anslist = new List<Recipients>();
            List<Recipients> ezerlist = new List<Recipients>();
            string[] id = ids.Split(',');
            for (int i = 0; i < id.Length-1; i++)
            {
                if (id[i] != "" || id[i] != "," || id[i]!=" ")
                {
                    ezerlist = selectRecipients(r => r.recipients_id == id[i]);
                    if (ezerlist.Count != 1)
                    {
                        throw new Exception("שגיאה - תז של מחולק לא נמצא במערכת");
                    }
                    anslist.Add(ezerlist[0]);
                }
            }
            return anslist;
        }

        public List<Admin> selectAdmins(Func<Admin, bool> predicat = null)
        {
            return dalImp.selectAdmins(predicat);
        }

        public List<WorkSchedule> selectWorkSchedule(Func<WorkSchedule, bool> predicat = null)
        {
            return dalImp.selectWorkSchedule(predicat);
        }


        /// <summary>
        /// מציאת חבילות לחלוקה לפי תאריך
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<Recipients> recipientsPackageByDay(DateTime date)
        {
            if (date.DayOfWeek != DayOfWeek.Saturday)
            {
                Func<Recipients, bool> predicat =
                (r => DateTime.Compare(r.recipients_package.package_finish_date, date) >= 0
             && r.recipients_package.package_frequency == frequency.יומי
            || (r.recipients_package.package_frequency == frequency.שבועי && date.DayOfWeek == DayOfWeek.Sunday)
            || (r.recipients_package.package_frequency == frequency.חודשי && date.DayOfWeek != DayOfWeek.Saturday && date.Day == 1)
            || (r.recipients_package.package_frequency == frequency.חודשי && date.DayOfWeek == DayOfWeek.Sunday && date.Day == 2));

                List<Recipients> myRecipients = selectRecipients(predicat);
                return myRecipients;
            }
            return new List<Recipients>();

        }
        /// <summary>
        /// מציאת חבילות לחלוקה לפי תאריך ועיר מוצא
        /// </summary>
        /// <param name="date"></param>
        /// <param name="city"></param>
        /// <returns></returns>
        public List<Recipients> recipientsPackageByDayAndCity(DateTime date, string city)
        {
            if (date.DayOfWeek != DayOfWeek.Saturday)
            {
                Func<Recipients, bool> predicat =
                    (r => r.recipients_address.address_city == city
                && DateTime.Compare(r.recipients_package.package_finish_date, date) >= 0
                && (r.recipients_package.package_frequency == frequency.יומי
               || (r.recipients_package.package_frequency == frequency.שבועי && date.DayOfWeek == DayOfWeek.Sunday)
               || (r.recipients_package.package_frequency == frequency.חודשי && date.DayOfWeek != DayOfWeek.Saturday && date.Day == 1)
               || (r.recipients_package.package_frequency == frequency.חודשי && date.DayOfWeek == DayOfWeek.Sunday && date.Day == 2)));

                List<Recipients> myRecipients = selectRecipients(predicat);
                return myRecipients;
            }
            return new List<Recipients>();
        }

        public void dayWorkSchedule(DateTime date)
        {
            Func<WorkSchedule, bool> predicat = (w=> w.workSchedule_date==date);
            List<WorkSchedule> workSchedules = selectWorkSchedule(predicat);
            List<Distributors> alldistributors = new List<Distributors>();
            List<Distributors> ezerList = new List<Distributors>();

            foreach (WorkSchedule item in workSchedules)
            {
                ezerList = selectDistributors(d => d.distributors_id == item.distributor_id);
                if (ezerList.Count != 1)
                {
                    throw new Exception("שגיאה בחיפוש אחרי מחלק זה");
                }
                alldistributors.Add(ezerList[0]);
            }

            List<Recipients> allrecipients = recipientsPackageByDay(date);

            double[][] Coordinates = new double[allrecipients.Count][];
            int i = 0;
            foreach (Recipients item in allrecipients)
            {
                Coordinates[i] = getLatLongFromAddress(item.recipients_address);
                i++;
            }

            // Create a new K-Means algorithm with 3 clusters 
            KMeans kmeans = new KMeans(3);

            // Compute the algorithm, retrieving an integer array
            //  containing the labels for each of the observations
            KMeansClusterCollection clusters = kmeans.Learn(Coordinates);

            // As a result, the first two observations should belong to the
            //  same cluster (thus having the same label). The same should
            //  happen to the next four observations and to the last three.
            int[] labels = clusters.Decide(Coordinates);

            List<Recipients> group0 = new List<Recipients>();
            List<Recipients> group1 = new List<Recipients>();
            List<Recipients> group2 = new List<Recipients>();

            for (int k=0; k<labels.Length; k++)
            {
                if (labels[k] == 0)
                {
                    group0.Add(allrecipients[k]);
                }
                if (labels[k] == 1)
                {
                    group1.Add(allrecipients[k]);
                }
                if (labels[k] == 2)
                {
                    group2.Add(allrecipients[k]);
                }
            }

            double lat = 0; double lon = 0;
            double[] d0 = new double[2];
            double[] d1 = new double[2];
            double[] d2 = new double[2];
            foreach (var item in group0)
            {
                d0 = getLatLongFromAddress(item.recipients_address);
                lat +=d0[0];
                lon += d0[1];
            }
            d0[0] = lat / group0.Count;
            d0[1] = lon / group0.Count;
            lat = 0; lon = 0;
            foreach (var item in group1)
            {
                d1 = getLatLongFromAddress(item.recipients_address);
                lat += d1[0];
                lon += d1[1];
            }
            d1[0] = lat / group1.Count;
            d1[1] = lon / group1.Count;
            lat = 0; lon = 0;
            foreach (var item in group2)
            {
                d2 = getLatLongFromAddress(item.recipients_address);
                lat += d2[0];
                lon += d2[1];
            }
            d2[0] = lat / group2.Count;
            d2[1] = lon / group2.Count;
           // double[] d0 = getLatLongFromAddress(group0[0].recipients_address);
           // double[] d1 = getLatLongFromAddress(group1[0].recipients_address);
           // double[] d2 = getLatLongFromAddress(group2[0].recipients_address);

            double[,] distance = new double[3, 3];
            for (i = 0; i < 3; i++)
            {
                double[] d3 = getLatLongFromAddress(alldistributors[i].distributors_address);
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0) distance[i, j] = dalImp.addressCalculations.calculateDistance(d0, d3);
                    if (j == 1) distance[i, j] = dalImp.addressCalculations.calculateDistance(d1, d3);
                    if (j == 2) distance[i, j] = dalImp.addressCalculations.calculateDistance(d2, d3);
                }
            }
            int [,] minIndex = new int[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                     minIndex[i, j] = findMinDist(distance[i, 0], distance[i, 1], distance[i, 2],j);
                }
            }

            if ((minIndex[0, 0] != minIndex[2, 0]) && (minIndex[0, 0] != minIndex[1, 0]) && (minIndex[2, 0] != minIndex[1, 0]))
            {
                if (minIndex[0, 0] == 0)
                {
                    UpdateWorkSchedule(new WorkSchedule(alldistributors[0].distributors_id, date, group0));
                    if(minIndex[1, 0] == 1)
                    {
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[1].distributors_id, date, group1));
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[2].distributors_id, date, group2));

                    }
                    else if (minIndex[1, 0] == 2)
                    {
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[1].distributors_id, date, group2));
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[2].distributors_id, date, group1));
                    }
                }
               else if (minIndex[0, 0] == 1)
                {
                    UpdateWorkSchedule(new WorkSchedule(alldistributors[0].distributors_id, date, group1));
                    if (minIndex[1, 0] == 0)
                    {
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[1].distributors_id, date, group0));
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[2].distributors_id, date, group2));

                    }
                    else if (minIndex[1, 0] == 2)
                    {
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[1].distributors_id, date, group2));
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[2].distributors_id, date, group0));
                    }
                }
               else if (minIndex[0, 0] == 2)
                {
                    UpdateWorkSchedule(new WorkSchedule(alldistributors[0].distributors_id, date, group2));
                    if (minIndex[1, 0] == 0)
                    {
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[1].distributors_id, date, group0));
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[2].distributors_id, date, group1));

                    }
                    else if (minIndex[1, 0] == 1)
                    {
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[1].distributors_id, date, group1));
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[2].distributors_id, date, group0));
                    }
                }
               
            }
            else
            {
                if ((minIndex[0, 0] == minIndex[2, 0]) && (minIndex[0, 0] == minIndex[1, 0]) && (minIndex[2, 0] == minIndex[1, 0]))
                {
                    UpdateWorkSchedule(new WorkSchedule(alldistributors[minIndex[0, 0]].distributors_id, date, group0));
                    if ((minIndex[1, 1] == minIndex[2, 1]))
                    {
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[minIndex[1, 1]].distributors_id, date, group1));
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[minIndex[2, 2]].distributors_id, date, group2));
                    }
                    else
                    {
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[minIndex[1, 1]].distributors_id, date, group1));
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[minIndex[2, 1]].distributors_id, date, group2));
                    }
                }
                else
                {
                    int place;
                    if (minIndex[1, 0] == minIndex[2, 0])
                    {
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[minIndex[0, 0]].distributors_id, date, group0));
                        place = minIndex[1, 1] + minIndex[1, 1] % 3;
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[minIndex[1, 0]].distributors_id, date, group1));
                        UpdateWorkSchedule(new WorkSchedule(alldistributors[place].distributors_id, date, group2));
                    }
                    else
                    {
                        if (minIndex[0, 0] == minIndex[2, 0])
                        {
                            UpdateWorkSchedule(new WorkSchedule(alldistributors[minIndex[1, 0]].distributors_id, date, group1));
                            place = minIndex[0, 0] + minIndex[1, 0] % 3;
                            UpdateWorkSchedule(new WorkSchedule(alldistributors[minIndex[0, 0]].distributors_id, date, group1));
                            UpdateWorkSchedule(new WorkSchedule(alldistributors[place].distributors_id, date, group2));
                        }
                        else
                        {
                            UpdateWorkSchedule(new WorkSchedule(alldistributors[minIndex[2, 0]].distributors_id, date, group2));
                            place = minIndex[0, 0] + minIndex[2, 0] % 3;
                            UpdateWorkSchedule(new WorkSchedule(alldistributors[minIndex[1, 1]].distributors_id, date, group0));
                            UpdateWorkSchedule(new WorkSchedule(alldistributors[place].distributors_id, date, group1));
                        }
                    }
                }
            }
        }

        public double[] getLatLongFromAddress(Address address)
        {
            return dalImp.addressCalculations.getLatLongFromAddress(address);
        }

        public int findMinDist(double one, double two, double three, int min)
        {
            if (min == 0)
            {
                if ((one < two) && (one < three)) return 0;
                if ((two < one) && (two < three)) return 1;
                return 2;
            }
            if(min == 1)
            {
                if (((two < one) && (one < three))|| ((three < one) && (one < two))) return 0;
                if (((one < two) && (two < three))|| ((three < two) && (two < one))) return 1;
                return 2;
            }
            if (min == 2)
            {
                if ((two < one) && (three < one)) return 0;
                if ((one < two) && (three < two)) return 1;
                return 2;
            }
            return 0;
        }
    }
}
