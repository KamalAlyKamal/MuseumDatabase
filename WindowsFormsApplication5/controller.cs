using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
namespace WindowsFormsApplication5
{

   public class controller
    {
        DBManager dbMan;
        public controller()
        {
            dbMan = new DBManager();
            dbMan.openconnector();
        }
        public int AddnewDepartment(int Depid, string Depname, char sec, int floor, int Budget)
        {
            string StoredProcedureName = StoredProcedures.insertdepartment;
            Dictionary<string, object> Paramters = new Dictionary<string, object>();
            Paramters.Add("@Depid", Depid);
            Paramters.Add("@Depname", Depname);
            Paramters.Add("@sec", sec);
            Paramters.Add("@floor", floor);
            Paramters.Add("@Budget", Budget);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Paramters);
        }
        public int AddNewInternalSupplies(int QuantityTotal, int QuantityResearch, int QuantityExhibits ,string SuppliedItemName ,int  SupplierID, int depId)
        {
            string StoredProcedureName = StoredProcedures.insertinternalsupplies;
            Dictionary<string, object> Paramters = new Dictionary<string, object>();
            Paramters.Add("@QuantityTotal", QuantityTotal);
            Paramters.Add("@QuantityResearch", QuantityResearch);
            Paramters.Add("@QuantityExhibits", QuantityExhibits);
            Paramters.Add("@SuppliedItemName", SuppliedItemName);
            Paramters.Add("@SupplierID", SupplierID);
            Paramters.Add("@DepId", depId);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Paramters);

        }

        public DataTable CountWorkers()
        {
            string StoredProcedureName = StoredProcedures.thenumberofworkers;        
            return dbMan.ExecuteReader(StoredProcedureName,null);
            

        }

        public DataTable CalculateProfit(int BCode)
        {
            
            string StoredProcedureName = StoredProcedures.calculateprofit;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BCode", BCode);
          //  Parameters.Add("@Profit", Profit);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable CountExhibits()
        {
            string StoredProcedureName = StoredProcedures.countexhibits;
            return dbMan.ExecuteReader(StoredProcedureName,null);
        }

        public DataTable EmployeesAverageSalary()
        {
            string StoredProcedureName = StoredProcedures.employeesaveragesalary;
            return dbMan.ExecuteReader(StoredProcedureName,null);
        }

        public DataTable GetHistoricalDocuments()
        {
            string StoredProcedureName = StoredProcedures.gethistoricaldocuments;
            return dbMan.ExecuteReader(StoredProcedureName,null);
        }

        public DataTable GetPaintings()
        {
            string StoredProcedureName = StoredProcedures.getpaintings;
            return dbMan.ExecuteReader(StoredProcedureName,null);
        }

        public DataTable GetSculptures()
        {
            string StoredProcedureName = StoredProcedures.getsculptures;
            return dbMan.ExecuteReader(StoredProcedureName,null);
        }

        public int UpdateSalesUnitCostandSellingPrice(int taxratio)
        {
            string StoredProcedureName = StoredProcedures.updatesalesunitcoseandsellingprice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@taxratio",taxratio);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        //Used in WelcomeForm1 for the log in button
        public int CheckLoginPassword(string username, string password)
        {
            string query = " select usertype from employee where ssn = '"+username+"' and password = '"+password+"'; ";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return 0;
            else return (int)p;
        }


        public int GetDepartmentManagetID(string ssn)
        {
            string query = " select DepartmentID from department_manager where SSN = '"+ssn+"' ; ";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return 0;
            else return (int)p;
        }

        public DataTable getallsalesnames()
        {
            string query = "Select * from Sales;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getallsalesinfo1()
        {
            string query = "Select * from Sales;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getallsuppliersnames()
        {
            string query = "Select * from Suppliers;";
            return dbMan.ExecuteReader(query);

        }
        //////////////////////////////////////Start ~ Ahmed//////////////////////////////////////////////////////
        public int DeleteDepartment(string DepID)
        {
            string query = "Delete from department where Departmentid = '" + DepID + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int EditDepartment(string DepID,string DerpartmentName, string Section, string Floor, string Budget)
        {
            string query = "UPDATE department SET DepartmentName ='" + DerpartmentName + "', Section='" + Section + "', Floor='" + Floor + "', Budget='" + Budget + "' WHERE Departmentid='" + DepID + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetDepartmentByID()
        {
            string query = "select * from department;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDepartmentByID(string ID)
        {
            string query = "select * from department where Departmentid = '"+ID+"';";
            return dbMan.ExecuteReader(query);
        }

        public int AddExhibit(string exhibitname, string YearAquired, string EstimatedValue, string SerialNumber, string DepartmentID, string Description="EMPTYY", string Photo="EMPTYY")
        {
            string query = "insert into exhibits values ('" + exhibitname + "', '" + YearAquired + "', '" + EstimatedValue + "', '" + SerialNumber + "', '" + Description + "', '" + Photo + "', '" + DepartmentID + "'); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddJewelery(string serialnumber, string type, string culture, string material)
        {
            string query = "insert into jewelery values ('" + serialnumber + "', '" + type + "', '" + culture + "', '" + material + "'); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetExhibitBySerialNumber(string serialNumber)
        {
            string query = "select * from exhibits where SerialNumber = '"+ serialNumber + "' ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetJeweleryBySerialNumber(string serialNumber)
        {
            string query = "select * from jewelery where Serial_Number = '" + serialNumber + "' ;";
            return dbMan.ExecuteReader(query);
        }

        public int EditExhibit(string serialnumber, string ExhibitName, string YearAquired, string EstimatedValue, string Description = "EMPTYY", string Photo="EMPTYY")
        {
            string query = "update exhibits set ExhibitName ='"+ ExhibitName + "', YearAcquired = '"+ YearAquired + "', EstimatedValue= '"+ EstimatedValue + "', Description = '"+ Description + "', Photo= '"+ Photo + "' where SerialNumber = '"+ serialnumber + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int EditJewelery(string serialnumber, string Type, string Culture, string Material )
        {
            string query = "update jewelery set Type='"+ Type + "',Culture='"+ Culture + "', Material='"+ Material + "' where Serial_Number = '" + serialnumber + "'  ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteJewelery(string serialnumber)
        {
            string query = "DELETE FROM jewelery WHERE Serial_Number = '"+ serialnumber + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteExhibit(string serialnumber)
        {
            string query = "DELETE FROM exhibits WHERE SerialNumber = '"+ serialnumber + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }
        

        ///////////////////////For Exhibits Display/////////////////////////
        public DataTable GetExhibitByDepartmentID(string DepartmentID)
        {
            string query = "select * from exhibits where DepartmentID = '" + DepartmentID + "' ;";
            return dbMan.ExecuteReader(query);
        }

        //Painting
        public DataTable GetDistinctPainterNames()
        {
            string query = "SELECT distinct PainterName FROM paintings ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDistinctPaintSchools()
        {
            string query = "SELECT distinct School FROM paintings ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayPaintingExhibitBySerialNumber(string SerialNumber)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description,p.SerialNumber, p.PainterName, p.School, p.size,  p.YearCompleted, p.PossessionType, p.ReturnDate, d.Section, d.Floor, d.Budget "
                            +"from Paintings as p, Exhibits as e, Department as d "
                            +"WHERE P.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId and e.DepartmentID = '"+7+"' and P.SerialNumber = '"+ SerialNumber + "' ;" ;
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayExhibitsByPainterNameSchool(string paintername, string school)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description,p.SerialNumber, p.PainterName, p.School, p.size,  p.YearCompleted, p.PossessionType, p.ReturnDate, d.Section, d.Floor, d.Budget "
                            + "from Paintings as p, Exhibits as e, Department as d "
                            + "WHERE P.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId and e.DepartmentID = '" + 7 + "' and P.PainterName = '"+ paintername + "' and P.School = '"+ school + "' ;";
            return dbMan.ExecuteReader(query);
        }

        //Sculpture
        public DataTable GetDistinctSculptureCultures()
        {
            string query = "SELECT distinct Culture FROM sculptures ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayExhibitBySculptureCulture(string culture)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, s.SculptorName,s.Material,s.Culture,s.Weight,s.YearCompleted, d.Budget "
                            +"from Sculptures as s, Exhibits as e, Department as d "
                            + "WHERE s.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId and s.Culture = '"+ culture + "'  ; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplaySculptureExhibitBySerialNumber(string SerialNumber)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, s.SculptorName,s.Material,s.Culture,s.Weight,s.YearCompleted, d.Budget "
                            + "from Sculptures as s, Exhibits as e, Department as d "
                            + "WHERE s.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId and s.SerialNumber = '"+ SerialNumber + "'  ; ";
            return dbMan.ExecuteReader(query);
        }

        //HistoricalEquipments
        public DataTable DisplayEquipments()
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.SerialNumber, H.Use, H.Culture, H.era, d.Floor, d.Budget, d.Section "
                            +"from historicalequipments as H, Exhibits as e, Department as d "
                            +"WHERE H.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDistinctEquipmentCultures()
        {
            string query = "SELECT distinct Culture FROM historicalequipments ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayEquipmentsBySerialNumber(string serialnumber)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.SerialNumber, H.Use, H.Culture, H.era, d.Floor, d.Budget, d.Section "
                            + "from historicalequipments as H, Exhibits as e, Department as d "
                            + "WHERE H.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId and H.SerialNumber = '"+ serialnumber + "' ; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayEquipmentsByCulture(string culture)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.SerialNumber, H.Use, H.Culture, H.era, d.Floor, d.Budget, d.Section "
                            + "from historicalequipments as H, Exhibits as e, Department as d "
                            + "WHERE H.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId and H.Culture = '"+ culture + "' ; ";
            return dbMan.ExecuteReader(query);
        }

        //Historical Documents
        public DataTable GetDistinctHistoricalDocumentDates()
        {
            string query = "SELECT distinct Date FROM historicaldocuments ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayDocumentsBySerialNumber(string serialnumber)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description,H.SerialNumber, H.Date, d.Floor, d.Budget, d.Section "
                            +"from HistoricalDocuments as H, Exhibits as e, Department as d "
                            + "WHERE H.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId and H.SerialNumber = '"+ serialnumber + "' ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayDocumentsByDate(string date)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description,H.SerialNumber, H.Date, d.Floor, d.Budget, d.Section "
                            + "from HistoricalDocuments as H, Exhibits as e, Department as d "
                            + "WHERE H.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId and H.Date =  '" + date + "' ;";
            return dbMan.ExecuteReader(query);
        }

        //HistoricalFossils
        public DataTable DisplayFossils()
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.SerialNumber, H.CarbonLevel, H.Species, H.Period, H.Status, H.Age, d.Floor, d.Section "
                            + "from historicalfossils as H, Exhibits as e, Department as d "
                            + "WHERE H.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDistinctFossilsPeriod()
        {
            string query = "SELECT distinct Period FROM historicalfossils ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayFossilsBySerialNumber(string serialnumber)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.SerialNumber, H.CarbonLevel, H.Species, H.Period, H.Status, H.Age, d.Floor, d.Section "
                            + "from historicalfossils as H, Exhibits as e, Department as d "
                            + "WHERE H.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId and H.SerialNumber = '"+ serialnumber + "' ; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayFossilsByPeriod(string Period)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.SerialNumber, H.CarbonLevel, H.Species, H.Period, H.Status, H.Age, d.Floor, d.Section "
                           + "from historicalfossils as H, Exhibits as e, Department as d "
                           + "WHERE H.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId and H.Period = '" + Period + "' ; ";
            return dbMan.ExecuteReader(query);
        }


        //Jewelery
        public DataTable DisplayJewelery()
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.Serial_Number, H.Type, H.Culture, H.Material, d.Floor, d.Section "
                            +"from jewelery as H, Exhibits as e, Department as d "
                            +"WHERE H.Serial_Number = e.SerialNumber and e.Departmentid = D.DepartmentId; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDistinctJeweleryTypes()
        {
            string query = "SELECT Distinct Type FROM jewelery ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayJeweleryBySerialNumber(string serialnumber)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.Serial_Number, H.Type, H.Culture, H.Material, d.Floor, d.Section "
                           + "from jewelery as H, Exhibits as e, Department as d "
                           + "WHERE H.Serial_Number = e.SerialNumber and e.Departmentid = D.DepartmentId and H.Serial_Number= '"+ serialnumber + "'  ; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayJeweleryByPeriod(string Period)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.Serial_Number, H.Type, H.Culture, H.Material, d.Floor, d.Section "
                           + "from jewelery as H, Exhibits as e, Department as d "
                           + "WHERE H.Serial_Number = e.SerialNumber and e.Departmentid = D.DepartmentId and H.Type= '" + Period + "'  ; ";
            return dbMan.ExecuteReader(query);
        }

        //Weapons
        public DataTable DisplayWeapons()
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.Serial_Number, H.Origin, H.WarsUsedAt, H.Material, H.Era, H.Type, d.Floor, d.Section "
                            +"from weaponandammunition as H, Exhibits as e, Department as d "
                            +"WHERE H.Serial_Number = e.SerialNumber and e.Departmentid = D.DepartmentId; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDistinctWeaponsOrigin()
        {
            string query = "SELECT Distinct Origin FROM weaponandammunition ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayWeaponBySerialNumber(string serialnumber)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.Serial_Number, H.Origin, H.WarsUsedAt, H.Material, H.Era, H.Type, d.Floor, d.Section "
                            + "from weaponandammunition as H, Exhibits as e, Department as d "
                            + "WHERE H.Serial_Number = e.SerialNumber and e.Departmentid = D.DepartmentId and H.Serial_Number = '"+ serialnumber + "' ; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayWeaponByOrigin(string Origin)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.Serial_Number, H.Origin, H.WarsUsedAt, H.Material, H.Era, H.Type, d.Floor, d.Section "
                            + "from weaponandammunition as H, Exhibits as e, Department as d "
                            + "WHERE H.Serial_Number = e.SerialNumber and e.Departmentid = D.DepartmentId and H.Origin = '" + Origin + "' ; ";
            return dbMan.ExecuteReader(query);
        }

        //Textiles
        public DataTable DisplayTextiles()
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.SerialNumber, H.Materials, H.Dimensions, H.Culture, d.Floor, d.Section "
                            +"from textiles as H, Exhibits as e, Department as d "
                            +"WHERE H.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDistinctTextilesCulture()
        {
            string query = "SELECT Distinct Culture FROM textiles ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayTextilesBySerialNumber(string serialnumber)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.SerialNumber, H.Materials, H.Dimensions, H.Culture, d.Floor, d.Section "
                            + "from textiles as H, Exhibits as e, Department as d "
                            + "WHERE H.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId and H.SerialNumber = '"+ serialnumber + "' ; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayTextilesByOrigin(string Culture)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.SerialNumber, H.Materials, H.Dimensions, H.Culture, d.Floor, d.Section "
                           + "from textiles as H, Exhibits as e, Department as d "
                           + "WHERE H.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId and H.Culture = '" + Culture + "' ; ";
            return dbMan.ExecuteReader(query);
        }

        //Instruments
        public DataTable DisplayInstruments()
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.Serial_Number, H.Type, H.Culture, H.Material, d.Floor, d.Section "
                            +"from musicalinstruments as H, Exhibits as e, Department as d "
                            +"WHERE H.Serial_Number = e.SerialNumber and e.Departmentid = D.DepartmentId; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDistinctInstrumentsCulture()
        {
            string query = "SELECT Distinct Culture FROM musicalinstruments;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayInstrumentsBySerialNumber(string serialnumber)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.Serial_Number, H.Type, H.Culture, H.Material, d.Floor, d.Section "
                            + "from musicalinstruments as H, Exhibits as e, Department as d "
                            + "WHERE H.Serial_Number = e.SerialNumber and e.Departmentid = D.DepartmentId and H.Serial_Number = '"+ serialnumber + "' ; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayInstrumentsByCulture(string Culture)
        {
            string query = "select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.Serial_Number, H.Type, H.Culture, H.Material, d.Floor, d.Section "
                            + "from musicalinstruments as H, Exhibits as e, Department as d "
                            + "WHERE H.Serial_Number = e.SerialNumber and e.Departmentid = D.DepartmentId and H.Culture = '" + Culture + "' ; ";
            return dbMan.ExecuteReader(query);
        }

        //Research
        public DataTable DisplayResearch()
        {
            string query = "select Type, Topic, Start_Date, End_Date, Status, Description from research; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDistinctResearchType()
        {
            string query = "select distinct type from Research;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDistinctResearchTopic()
        {
            string query = "select distinct Topic from Research;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayResearchByType(string type)
        {
            string query = "select Type, Topic, Start_Date, End_Date, Status, Description from research where Type = '"+ type + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable DisplayResearchByTopic(string topic)
        {
            string query = "select Type, Topic, Start_Date, End_Date, Status, Description from research where Topic = '"+topic+"' ;";
            return dbMan.ExecuteReader(query);
        }
////////////////////////////////////////End ~ Ahmed//////////////////////////////////////////////////////

////////////////////////////////////////Start ~ Kamal//////////////////////////////////////////////////////
        public int AddHistoricalDocuments(int serialnumber, string Date, string Name, string YearAcquired, int EstimatedValue, string Description, string PhotoLink, int DepartmentID)
        {
            string query1 = "Insert into exhibits values('" + Name + "','" + YearAcquired + "','" + EstimatedValue + "','" + serialnumber + "','" + Description + "','" + PhotoLink + "','" + DepartmentID + "');";
            string query2 = "Insert into historicaldocuments values('" + serialnumber + "','" + Date + "');";
            dbMan.ExecuteNonQuery(query1);
            return dbMan.ExecuteNonQuery(query2);
        }

        public DataTable GetExhibitsbySerialNumber(int serialnumber)
        {
            string query = "select * from exhibits where SerialNumber = '" + serialnumber + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetHistoricalDocumentsbySerialNumber(int serialnumber)
        {
            string query = "select Date from historicaldocuments where SerialNumber = '" + serialnumber + "';";
            return dbMan.ExecuteReader(query);
        }

        public int EditHistoricalDocuments(string serialnumber, string Date, string EstimatedValue, string Name, string Description, string YearAcquired, string PhotoLink, string DepartmentID)
        {
            string query1 = "update exhibits set ExhibitName='" + Name + "',YearAcquired='" + YearAcquired + "',EstimatedValue='" + EstimatedValue + "',Description='" + Description + "',Photo='" + PhotoLink + "'where SerialNumber='" + serialnumber + "';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "update historicaldocuments set Date='" + Date + "'where SerialNumber='" + serialnumber + "';";
            return dbMan.ExecuteNonQuery(query2);
        }

        public int DeleteHistoricalDocuments(string serialnumber)
        {
            string query1 = "delete from historicaldocuments where SerialNumber='" + serialnumber + "';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "delete from exhibits where SerialNumber='" + serialnumber + "';";
            return dbMan.ExecuteNonQuery(query2);
        }

        public int AddWeaponsandAmmunition(string serialnumber, string origin, string name, string warsusedat, string yearacquired, string material, string estimatedvalue, string era, string description, string type, string photolink, string departmentid)
        {
            string query1 = "Insert into exhibits values('" + name + "','" + yearacquired + "','" + estimatedvalue + "','" + serialnumber + "','" + description + "','" + photolink + "','" + departmentid + "');";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "Insert into weaponandammunition values('" + serialnumber + "','" + origin + "','" + warsusedat + "','" + material + "','" + era + "','" + type + "');";
            return dbMan.ExecuteNonQuery(query2);
        }

        public DataTable GetWeaponandAmmunitionbyserialnumber(string serialnumber)
        {
            string query = "select Origin,WarsUsedAt,Material,Era,Type from weaponandammunition where Serial_Number = '" + serialnumber + "';";
            return dbMan.ExecuteReader(query);
        }

        public int EditWeaponandAmmunition(string serialnumber, string name, string warsusedat, string yearacquired, string origin, string estimatedvalue, string material, string description, string era, string photolink, string type, string departmentid)
        {
            string query1 = "update exhibits set ExhibitName = '" + name + "',YearAcquired = '" + yearacquired + "',EstimatedValue = '" + estimatedvalue + "',Description = '" + description + "',Photo = '" + photolink + "',DepartmentID = '" + departmentid + "'where SerialNumber = '" + serialnumber + "';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "update weaponandammunition set Origin = '" + origin + "',WarsUsedAt = '" + warsusedat + "',Material = '" + material + "',Era = '" + era + "',Type = '" + type + "' where Serial_Number = '" + serialnumber + "';";
            return dbMan.ExecuteNonQuery(query2);
        }

        public int DeleteWeaponandAmmunition(string serialnumber)
        {
            string query1 = "Delete from weaponandammunition where Serial_Number = '" + serialnumber + "';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "Delete from exhibits where SerialNumber = '" + serialnumber + "';";
            return dbMan.ExecuteNonQuery(query2);
        }

        public int AddMusicalInstrument(string serialnumber, string culture, string type, string material, string name, string estimatedvalue, string yearacquired, string description, string photolink, string departmentid)
        {
            string query1 = "Insert into exhibits values('" + name + "','" + yearacquired + "','" + estimatedvalue + "','" + serialnumber + "','" + description + "','" + photolink + "','" + departmentid + "');";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "Insert into musicalinstruments values('" + serialnumber + "','" + type + "','" + culture + "','" + material + "');";
            return dbMan.ExecuteNonQuery(query2);
        }

        public DataTable GetMusicalInstrumentsbyserialnumber(string serialnumber)
        {
            string query = "Select Type,Culture,Material from musicalinstruments where Serial_Number = '" + serialnumber + "';";
            return dbMan.ExecuteReader(query);
        }

        public int EditMusicalInstrument(string serialnumber, string culture, string material, string type, string estimatedvalue, string name, string description, string yearacquired, string photolink)
        {
            string query1 = "Update exhibits set ExhibitName = '" + name + "',YearAcquired = '" + yearacquired + "',EstimatedValue = '" + estimatedvalue + "',Description = '" + description + "',Photo = '" + photolink + "' where SerialNumber = '" + serialnumber + "';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "Update musicalinstruments set Type = '" + type + "',Culture = '" + culture + "',Material = '" + material + "' where Serial_Number = '" + serialnumber + "';";
            return dbMan.ExecuteNonQuery(query2);
        }

        public int DeleteMusicalInstrument(string serialnumber)
        {
            string query1 = "Delete from musicalinstruments where Serial_Number = '" + serialnumber + "';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "Delete from exhibits where SerialNumber = '" + serialnumber + "';";
            return dbMan.ExecuteNonQuery(query2);
        }

        public DataTable GetTextilesbyserialnumber(string serialnumber)
        {
            string query = "Select Materials,Dimensions,Culture from textiles where SerialNumber = '" + serialnumber + "';";
            return dbMan.ExecuteReader(query);
        }

        public int AddTextiles(string serialnumber, string material, string dimensions, string culture, string name, string estimatedvalue, string yearacquired, string description, string photolink, string departmentid)
        {
            string query1 = "Insert into exhibits values('" + name + "','" + yearacquired + "','" + estimatedvalue + "','" + serialnumber + "','" + description + "','" + photolink + "','" + departmentid + "');";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "Insert into textiles values('" + serialnumber + "','" + material + "','" + dimensions + "','" + culture + "');";
            return dbMan.ExecuteNonQuery(query2);
        }

        public int EditTextiles(string serialnumber, string material, string dimensions, string culture, string name, string estimatedvalue, string yearacquired, string description, string photolink)
        {
            string query1 = "Update exhibits set ExhibitName = '" + name + "',YearAcquired = '" + yearacquired + "',EstimatedValue = '" + estimatedvalue + "',Description = '" + description + "',Photo = '" + photolink + "' where SerialNumber = '" + serialnumber + "';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "Update textiles set Materials = '" + material + "',Dimensions = '" + dimensions + "',Culture = '" + culture + "' where SerialNumber = '" + serialnumber + "';";
            return dbMan.ExecuteNonQuery(query2);
        }

        public int DeleteTextiles(string serialnumber)
        {
            string query1 = "Delete from textiles where SerialNumber = '" + serialnumber + "';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "Delete from exhibits where SerialNumber = '" + serialnumber + "';";
            return dbMan.ExecuteNonQuery(query2);
        }

        public DataTable GetPaintingbyserialnumber(string serialnumber)
        {
            string query = "Select PainterName,School,size,YearCompleted,PossessionType,ReturnDate from paintings where SerialNumber = '" + serialnumber + "';";
            return dbMan.ExecuteReader(query);
        }
        //
        public int AddPainting(string serialnumber, string name, string paintername, string estimatedvalue, string school, string yearacquired, string yearcompleted, string description, string size, string photolink, string typeofpossession, string returndate, string departmentid)
        {
            string query1 = "Insert into exhibits values('" + name + "','" + yearacquired + "','" + estimatedvalue + "','" + serialnumber + "','" + description + "','" + photolink + "','" + departmentid + "');";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "Insert into paintings values('" + serialnumber + "','" + paintername + "','" + school + "','" + size + "','" + yearcompleted + "','" + typeofpossession + "','" + returndate + "');";
            return dbMan.ExecuteNonQuery(query2);
        }

        public int EditPainting(string serialnumber, string name, string paintername, string estimatedvalue, string school, string yearacquired, string yearcompleted, string description, string size, string photolink, string typeofpossession, string returndate)
        {
            string query1 = "Update exhibits set ExhibitName = '" + name + "',YearAcquired = '" + yearacquired + "',EstimatedValue = '" + estimatedvalue + "',Description = '" + description + "',Photo = '" + photolink + "' where SerialNumber = '" + serialnumber + "';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "Update paintings set PainterName = '" + paintername + "',School = '" + school + "',size = '" + size + "',YearCompleted = '" + yearcompleted + "',PossessionType = '" + typeofpossession + "',ReturnDate = '" + returndate + "';";
            return dbMan.ExecuteNonQuery(query2);
        }

        public int DeletePainting(string serialnumber)
        {
            string query1 = "Delete from paintings where SerialNumber = '" + serialnumber + "';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "Delete from exhibits where SerialNumber = '" + serialnumber + "';";
            return dbMan.ExecuteNonQuery(query2);
        }
////////////////////////////////////////End ~ Kamal//////////////////////////////////////////////////////

////////////////////////////////////////Start ~ Osman//////////////////////////////////////////////////////
        public DataTable getinfo(string sn)
        {
            string quere = "SELECT * FROM employee where SSN='" + sn + "';";
            return dbMan.ExecuteReader(quere);
        }

        public int addnewsupplier(string supplierid, string suppliername, string fax, string address, string city, string region, string postalcode, string phone, string homepage)
        {
            string query = "insert into suppliers values ('" + supplierid + "','" + suppliername + "','" + fax + "','" + address + "','" + city + "','" + region + "','" + postalcode + "','" + phone + "','" + homepage + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        //osman 
        public DataTable getsupplierbysupplierid(string select)
        {
            string query = "select * from suppliers where SupplierID = '" + select + "';";
            return dbMan.ExecuteReader(query);

        }
        public DataTable getsupplierbysuppliername(string select)
        {
            string query = "select * from suppliers where SupplierName = '" + select + "';";
            return dbMan.ExecuteReader(query);

        }

        public int editnewsupplier(string t8, string t9, string t10, string t11, string t12, string t13, string t14, string t15, string select)
        {
            string query = "update suppliers set SupplierName = '" + t8 + "'," + " Address ='" + t9 + "'," + " City = '" + t10 + "', Phone = '" + t11 + "', Fax = '" + t12 + "',Region = '" + t13 + "', PostalCode = '" + t14 + "', HomePage = '" + t15 + "' where SupplierID = '" + select + "';";

            return dbMan.ExecuteNonQuery(query);
        }

        public int deletesupplier(string s)
        {
            string query = "delete from suppliers where SupplierID ='" + s + "';";
            return dbMan.ExecuteNonQuery(query);


        }
        public DataTable getemployeebyssn(string t)
        {
            string query = "select * from employee where SSN='" + t + "';";
            return dbMan.ExecuteReader(query);

        }
        public int updateworkerbyssn(string a, string b, string c)
        {
            string query = "update workers set ShiftTime = ' " + a + "', JobTitle = '" + b + "'where SSN='" + c + "';";
            return dbMan.ExecuteNonQuery(query);
        }


        //1suppliers 
        //osman 
        public DataTable getworkerbyssn(string t)
        {
            string query = "select * from workers where SSN='" + t + "';";
            return dbMan.ExecuteReader(query);

        }
        public DataTable getallworkers()
        {
            string query = "select * from workers ;";
            return dbMan.ExecuteReader(query);
        }
        public int addworker(string a, string b, string c, string d)
        {
            string query = "insert into workers values('" + a + "','" + b + "','" + c + "','" + d + "');";
            string query2 = "update employee set userType = 1 where SSN = '" + a + "';";
            dbMan.ExecuteNonQuery(query2);
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable getworkersofmanager(string managerssn)
        {
            string query = "select * from workers where WorkerMngrSSN ='" + managerssn + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable selectallemployees()
        {
            string query = "select SSN,Fname,Lname ,YearsofExperience from employee where userType = 0";
            return dbMan.ExecuteReader(query);
        }
        public int deletefromworkers(string t)
        {
            string query2 = "update employee set userType = 0 where SSN = '" + t + "';";
            dbMan.ExecuteNonQuery(query2);
            string query = "delete  from workers where SSN ='" + t + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        //osman historicalequipment 
        public int addhistoricalequipment(string a, string b, string c, string d)
        {
            string query = "insert into historicalequipments values ('" + a + "','" + b + "','" + c + "','" + d + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int addexhibits(string n, string D, string e, string s, string dis, string p, string did = "8")
        {
            string query = "insert into exhibits values (' " + n + "','" + D + "','" + e + "','" + s + "','" + dis + "','" + p + "','" + did + "');";
            return dbMan.ExecuteNonQuery(query);


        }
        public DataTable getallequipments()
        {
            string query = "select * from historicalequipments";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getequipwithsn(string s)
        {
            string query = "select * from historicalequipments where SerialNumber = '" + s + "';";
            return dbMan.ExecuteReader(query);
        }
        public int updateequipment(string a, string c, string d, string w)
        {
            string query = "update historicalequipments set historicalequipments.Use='" + a + "',Culture ='" + c + "',era ='" + d + "' where SerialNumber='" + w + "';";
            return dbMan.ExecuteNonQuery(query);

        }
        public int deleteequipment(string w)
        {
            string query = " delete from historicalequipments where SerialNumber='" + w + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getworkermanagerinfo(string s)
        {
            string query = "select * from worker_manager where SSN ='" + s + "';";
            return dbMan.ExecuteReader(query);

        }
        public int updateemployee(string s, string s1, string s2, string s3, string s4, string s6, string s7, string s8, string s9, string s10)
        {
            string query = "update employee set Fname = '" + s1 + "',Minit ='" + s2 + "',Lname = '" + s3 + "',Address ='" + s4 + "',PostalCode='" + s6 + "',Country='" + s7 + "',HomePhone='" + s8 + "',MobilePhone='" + s9 + "',YearsofExperience='" + s10 + "'where SSN ='" + s + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        //osman sculpt
        public int addsculpt(string s1, string s2, string s3, string s4, string s5, string s6)
        {
            string query = "insert into sculptures values('" + s1 + "','" + s2 + "','" + s3 + "','" + s4 + "','" + s5 + "','" + s6 + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable getallsclupt()
        {
            string query = "select * from sculptures";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getallscluptwithsn(string t)
        {
            string query = "SELECT m.SculptorName,m.Material,m.Culture,m.Weight,m.YearCompleted ,e.EstimatedValue,e.Description,e.Photo,e.YearAcquired FROM   museum.sculptures as m,exhibits as e where e.SerialNumber = m.SerialNumber and m.SerialNumber='" + t + "';";
            return dbMan.ExecuteReader(query);
        }
        public int editsclupt(string s, string s1, string s2, string s3, string s4, string s5)
        {

            string query = "update sculptures set SculptorName = '" + s1 + "',Material='" + s2 + "',Culture ='" + s3 + "',Weight ='" + s4 + "',YearCompleted= '" + s5 + "' where SerialNumber ='" + s + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int deletsclupt(string s)
        {
            string query = "delete from sculptures where SerialNumber =' " + s + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public bool checkpassword(string s1, string s3)
        {
            string query1 = " select Password from employee where SSN=' " + s3 + "';";
            DataTable dt = dbMan.ExecuteReader(query1);
            string oldpass = dt.Rows[0][0].ToString();
            if (oldpass == s1)
            {
                return true;
            }
            return false;
        }
        public int changepassword(string s2, string s3)
        {

            string query1 = " update employee set Password = '" + s2 + "' where SSN ='" + s3 + "';";
            return dbMan.ExecuteNonQuery(query1);
        }
        public int promotwo(string s)
        {
            string query = "update employee set userType = 3 where SSN = '" + s + "'; ";
            return dbMan.ExecuteNonQuery(query);
        }
        public int promotone(string s)
        {
            string query = "update employee set userType = 2 where SSN = '" + s + "'; ";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable selecttopromote()
        {
            string query = "select SSN,Fname,Lname ,YearsofExperience from employee where userType = 1";
            return dbMan.ExecuteReader(query);
        }
        ////////////////////////////////////////End ~ Osman//////////////////////////////////////////////////////

        ////////////////////////////////////////Start ~ Tim`//////////////////////////////////////////////////////

        public DataTable getsalestodisplay()
        {
            string query = "select ItemName, QuantityStock, SellingPrice, DiscountPercentage from sales ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getallsalesinfo()
        {
            string query = "select ItemName,BarCode,QuantityStock,QuantityOrder,SupplierName,SellingPrice,UnitCost,DiscountPercentage,DepartmentID from sales as s , suppliers as i where i.SupplierID = s.SupplierID ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getallsalesinfobyname(string barcode)
        {
            string query = "select ItemName,BarCode,QuantityStock,QuantityOrder,SupplierName,SellingPrice,UnitCost,DiscountPercentage,DepartmentID from sales as s , suppliers as i where i.SupplierID = s.SupplierID and BarCode ='" + barcode + "'  ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getquantitystock(String ItemName)
        {
            string query = "select QuantityStock from sales  where ItemName = '" + ItemName + "' ;";
            return dbMan.ExecuteReader(query);
        }


        public int updatesalesafterselling(int Quantityleft, string ItemName)
        {

            string query = "update sales set QuantityStock ='" + Quantityleft + "' where ItemName = '" + ItemName + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getsupplieditems()
        {

            string query = "select QuantityTotal,QuantityResearch,QuantityExhibits,SuppliedItemName,SupplierName,DepartmentID  from  internalsupplies as i , sales as s  where i.SupplierID = s.SupplierID ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getallsuppliersinfo()
        {
            string query = "select * from suppliers  ;";
            return dbMan.ExecuteReader(query);
        }

        public int addsalesitem(string ItemName, string BarCode, string QuantityStock, string QuantityOrder, string SupplierID, string SellingPrice, string UnitCost, string DiscountPercentage, string DepartmentID)
        {
            string query = "insert into sales values ('" + ItemName + "', '" + BarCode + "', '" + QuantityStock + "', '" + QuantityOrder + "', '" + SupplierID + "', '" + SellingPrice + "','" + UnitCost + "','" + DiscountPercentage + "','" + DepartmentID + "'); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updatesalesitem(string BarCode, string barcode, string QuantityStock, string QuantityOrder, string SupplierID, string SellingPrice, string UnitCost, string DiscountPercentage)
        {

            string query = "update sales set BarCode ='" + barcode + "',QuantityStock ='" + QuantityStock + "',QuantityOrder ='" + QuantityOrder + "',SupplierID ='" + SupplierID + "',SellingPrice ='" + SellingPrice + "',UnitCost ='" + UnitCost + "',DiscountPercentage ='" + DiscountPercentage + "' where BarCode = '" + BarCode + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deletesalesitem(string BarCode)
        {
            string query = "delete from sales where BarCode = '" + BarCode + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getallinternalsupplyitems()
        {
            string query = "select QuantityTotal,QuantityResearch,QuantityExhibits,SuppliedItemName,SupplierName,DepartmentID from internalsupplies as i , suppliers as s where i.SupplierID = s.SupplierID  ;";
            return dbMan.ExecuteReader(query);
        }


        public DataTable getallinternalsupplyinfobyname(string SuppliedItemName)
        {
            string query = "select QuantityTotal , QuantityResearch , QuantityExhibits , SuppliedItemName ,SupplierName ,DepartmentID from internalsupplies as i , suppliers as s where SuppliedItemName = '" + SuppliedItemName + "' and i.SupplierID = s.SupplierID; ";
            return dbMan.ExecuteReader(query);
        }

        public int updateinternalsuppliesitem(string SuppliedItemName, string QuantityTotal, string QuantityResearch, string QuantityExhibits, string SupplierID)
        {

            string query = "update internalsupplies set QuantityTotal ='" + QuantityTotal + "',QuantityResearch ='" + QuantityResearch + "',QuantityExhibits ='" + QuantityExhibits + "',SupplierID ='" + SupplierID + "' where SuppliedItemName = '" + SuppliedItemName + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }


        public int deleteinternalsuppliesitem(string SuppliedItemName)
        {
            string query = "delete from internalsupplies where SuppliedItemName = '" + SuppliedItemName + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }




        public int addresearch(string Type, string Topic, string Researcher_SSN, string Start_Date, string End_Date, string Status, string Description, string DepartmentID)
        {
            string query = "insert into research values ('" + Type + "', '" + Topic + "', '" + Researcher_SSN + "', '" + Start_Date + "', '" + End_Date + "', '" + Status + "','" + Description + "','" + DepartmentID + "'); ";
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable getresearchbytypeandtopic(string type, string topic)
        {
            string query = "select * from research where Topic = '" + topic + "' and Type = '" + type + "' ;";
            return dbMan.ExecuteReader(query);
        }

        public int updateresearch(string type, string topic, string Researcher_SSN, string End_Date, string Status, string Description)
        {

            string query = "update research set Researcher_SSN ='" + Researcher_SSN + "',End_Date ='" + End_Date + "',Status ='" + Status + "',Description ='" + Description + "' where Type = '" + type + "' and Topic = '" + topic + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int deleteresearch(string type, string topic)
        {
            string query = "delete from research where Type = '" + type + "'and Topic = '" + topic + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }



        public int addfossils(string SerialNumber, string CarbonLevel, string Species, string Period, string Status, string Age)
        {
            string query = "insert into historicalfossils values ('" + SerialNumber + "', '" + CarbonLevel + "', '" + Species + "', '" + Period + "','" + Status + "','" + Age + "'); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getfossilsbyserialnumber(string serialNumber)
        {
            string query = "select CarbonLevel,Species,Period,Status,Age from historicalfossils where SerialNumber = '" + serialNumber + "' ;";
            return dbMan.ExecuteReader(query);
        }


        public int updatefossils(string serialnumber, string CarbonLevel, string Species, string Period, string Status, string Age)
        {
            string query = "update historicalfossils set SerialNumber='" + serialnumber + "',CarbonLevel='" + CarbonLevel + "', Species='" + Species + "',Period='" + Period + "' ,Status='" + Status + "',Age='" + Age + "' where SerialNumber = '" + serialnumber + "'  ;";
            return dbMan.ExecuteNonQuery(query);
        }


        public int deletefossils(string serialnumber)
        {
            string query = "delete from historicalfossils where SerialNumber = '" + serialnumber + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }

////////////////////////////////////////End ~ Tim`//////////////////////////////////////////////////////


    }
}
