using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Reflection;
using GCDataTier;

namespace GCBLL
{
    public class VolunteerImport
    {
        public void ImportVolunteerInformation(DataSet ds)
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public static T CreateListItem<T>(DataRow dRow)
        { 
            T obj = default(T);

            if (dRow != null)
            {
                obj = Activator.CreateInstance<T>();
                foreach (DataColumn dCol in dRow.Table.Columns)
                {
                    try
                    {
                        PropertyInfo objProp = obj.GetType().GetProperty(dCol.ColumnName);
                        if (dCol.ColumnName == "Attendee #")
                            dCol.ColumnName = "SignUpPartyId";
                        if (dCol.ColumnName == "Date")
                            dCol.ColumnName = "SignUpDate";
                        objProp.SetValue(obj, dRow[dCol.ColumnName].ToString(), null);

                        //if (System.DBNull.Value == dRow[dCol.ColumnName])
                        //    objProp.SetValue(obj, dRow[dCol.ColumnName].ToString(), null);
                        //else
                        //    objProp.SetValue(obj, dRow[dCol.ColumnName],null);

                        
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }


            return obj;
        }

    }


}
