using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data;
using System.Web.Script.Serialization;

namespace Farm_Tracker
{
    class API
    {
        //OPERATOR
        public class farmOperator
        {
            public int? ID { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string language { get; set; }
            public string position { get; set; }
            public string email { get; set; }
            public string phoneNumber { get; set; }
            public string password { get; set; }

            public farmOperator()
            {
                ID = null;
                firstName = null;
                lastName = null;
                language = null;
                position = null;
                email = null;
                phoneNumber = null;
                password = null;
            }

        }
        public static void createOperator(farmOperator newOperator)
        {
            string queryString = "";
            string queryString1 = "insert into Operators (";
            string queryString2 = " values (";
            queryString1 += "Operators.first_Name, ";
            queryString2 += "'" + newOperator.firstName + "',";
            queryString1 += "Operators.Last_Name, ";
            queryString2 += "'" + newOperator.lastName + "',";
            queryString1 += "Operators.Position, ";
            queryString2 += "'" + newOperator.position + "',";
            queryString1 += "Operators.Language, ";
            queryString2 += "'" + newOperator.language + "',";

            if (newOperator.email != null)
            {
                queryString1 += "Operators.Email, ";
                queryString2 += "'" + newOperator.email + "',";
            }
            if (newOperator.phoneNumber != null)
            {
                queryString1 += "Operators.Phone_Number, ";
                queryString2 += "'" + newOperator.phoneNumber + "',";
            }

            queryString1 += "Operators.Password)";
            queryString2 += "'" + newOperator.password + "')";

            queryString = queryString1 + queryString2;

            string queryMessage = "Create operator";
            string querySuccess = "Operator has been created.";
            string queryFail = "There was a problem, the operator was not created.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static string retrieveAllOperators()
        {
            String queryString = "select * from Operators ";
            string results = queryRetrieve(queryString);
            return results;
        }
        public static string retrieveOperator(string ID)
        {
            String queryString = "select * from Operators where Operators.Operator_ID = " + ID;
            string results = queryRetrieve(queryString);
            return results;
        }
        public static void updateOperator(farmOperator operatorToUpdate)
        {
            int count = 0;

            string queryString = "update Operators set ";
            
            if (operatorToUpdate.firstName != null){
                count++;
                queryString += "Operators.First_Name = '" + operatorToUpdate.firstName + "'";
            }
            if (operatorToUpdate.lastName != null)
            {
                if(count >= 1)
                {
                    queryString += ",";
                }
                queryString += " Operators.Last_Name = '" + operatorToUpdate.lastName + "'";
                count++;
            }
            if (operatorToUpdate.position != null)
            {
                if(count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Operators.Position = '" + operatorToUpdate.position + "'";
                count++;
            }
            if (operatorToUpdate.language != null)
            {
                if(count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Operators.Language = '" + operatorToUpdate.language + "'";
                count++;
            }
            if (operatorToUpdate.email != null)
            {
                if(count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Operators.Email = '" + operatorToUpdate.email + "'";
                count++;
            }
            if (operatorToUpdate.phoneNumber != null)
            {
                if(count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Operators.Phone_Number = '" + operatorToUpdate.phoneNumber + "'";
                count++;
            }
            if (operatorToUpdate.password != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Operators.Password = '" + operatorToUpdate.password + "'";
            }

            queryString += " Where Operators.Operator_ID = " + operatorToUpdate.ID; 

            string queryMessage = "Update operator";
            string querySuccess = "Operator has been updated.";
            string queryFail = "There was a problem, the operator was not updated.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);

        }
        public static void deleteOperator(int ID)
        {
            string queryString = "delete from Operators where Operators.Operator_ID = '" + ID.ToString() + "'";

            string message = "Delete operator";
            string success = "Operator has been deleted.";
            string fail = "There was a problem, the operator was not deleted.";

            executeDelete(queryString, message, success, fail);
            
        }
        
        //EQUIPMENT
        public class farmEquipment
        {
            public int? ID { get; set; }
            public string equipmentType { get; set; }
            public int? year { get; set; }
            public string brand { get; set; }
            public string serialNumber { get; set; }
            public string modelNumber { get; set; }
            public int? hours { get; set; }
            public int? horsepower { get; set; }
            public int? numberOfTanks { get; set; }
            public int? tankSize { get; set; }
            public int? width { get; set; }
            public int? shank_Spacing { get; set; }
            public string image { get; set; }
            public bool? operational { get; set; }

            public farmEquipment()
            {
                ID = null;
                equipmentType = null;
                year = null;
                brand = null;
                serialNumber = null;
                modelNumber = null;
                hours = null;
                horsepower = null;
                numberOfTanks = null;
                tankSize = null;
                width = null;
                shank_Spacing = null;
                image = null;
                operational = null;
            }

        }
        public static void createEquipment(farmEquipment newEquipment)
        {
            string queryString = "";
            string queryString1 = "insert into Equipment (";
            string queryString2 = " values (";
            queryString1 += "Equipment.equipment_Type, ";
            queryString2 += "'" + newEquipment.equipmentType + "',";
            queryString1 += "Equipment.Year, ";
            queryString2 += "'" + newEquipment.year + "',";
            queryString1 += "Equipment.Brand, ";
            queryString2 += "'" + newEquipment.brand+ "',";
            queryString1 += "Equipment.Serial_Number, ";
            queryString2 += "'" + newEquipment.serialNumber + "',";
            queryString1 += "Equipment.Model_Number, ";
            queryString2 += "'" + newEquipment.modelNumber + "',";
            queryString1 += "Equipment.Hours, ";
            queryString2 += "'" + newEquipment.hours + "',";

            if (newEquipment.horsepower != null)
            {
                queryString1 += "Equipment.Horsepower, ";
                queryString2 += "'" + newEquipment.horsepower + "',";
            }
            if (newEquipment.numberOfTanks != null)
            {
                queryString1 += "Equipment.Number_Of_Tanks, ";
                queryString2 += "'" + newEquipment.numberOfTanks + "',";
            }
            if (newEquipment.tankSize != null)
            {
                queryString1 += "Equipment.Tank_Size, ";
                queryString2 += "'" + newEquipment.tankSize + "',";
            }
            if (newEquipment.width != null)
            {
                queryString1 += "Equipment.Width, ";
                queryString2 += "'" + newEquipment.width + "',";
            }
            if (newEquipment.shank_Spacing != null)
            {
                queryString1 += "Equipment.Shank_Spacing, ";
                queryString2 += "'" + newEquipment.shank_Spacing + "',";
            }
            if (newEquipment.image != null)
            {
                queryString1 += "Equipment.Image, ";
                queryString2 += "'" + newEquipment.image + "',";
            }

            queryString1 += "Equipment.Operational)";
            queryString2 += "'" + newEquipment.operational + "')";

            queryString = queryString1 + queryString2;

            string queryMessage = "Create operator";
            string querySuccess = "Operator has been created.";
            string queryFail = "There was a problem, the operator was not created.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static string retrieveAllEquipment()
        {
            String queryString = "select * from Equipment ";

            string results = queryRetrieve(queryString);
            return results;
        }
        public static string retrieveEquipment(string ID)
        {
            String queryString = "select * from Equipment where Equipment_ID = " + ID;

            string results = queryRetrieve(queryString);
            return results;
        }
        public static void updateEquipment(farmEquipment equipmentToUpdate)
        {
            int count = 0;

            string queryString = "update Equipment set ";
            
            if (equipmentToUpdate.equipmentType != null)
            {
                count++;
                queryString += "Equipment.Equipment_Type = '" + equipmentToUpdate.equipmentType + "'";
            }
            if (equipmentToUpdate.year != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += " Equipment.Year = '" + equipmentToUpdate.year + "'";
                count++;
            }
            if (equipmentToUpdate.brand != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Brand = '" + equipmentToUpdate.brand + "'";
                count++;
            }
            if (equipmentToUpdate.serialNumber != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Serial_Number = '" + equipmentToUpdate.serialNumber + "'";
                count++;
            }
            if (equipmentToUpdate.modelNumber != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Model_Number = '" + equipmentToUpdate.modelNumber + "'";
                count++;
            }
            if (equipmentToUpdate.hours != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Hours = '" + equipmentToUpdate.hours + "'";
                count++;
            }
            if (equipmentToUpdate.horsepower != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Horsepower = '" + equipmentToUpdate.horsepower + "'";
                count++;
            }
            if (equipmentToUpdate.numberOfTanks != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Number_Of_Tanks = '" + equipmentToUpdate.numberOfTanks + "'";
                count++;
            }
            if (equipmentToUpdate.tankSize != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Tank_Size = '" + equipmentToUpdate.tankSize + "'";
                count++;
            }
            if (equipmentToUpdate.width != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Width = '" + equipmentToUpdate.width + "'";
                count++;
            }
            if (equipmentToUpdate.shank_Spacing != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Shank_Spacing = '" + equipmentToUpdate.shank_Spacing + "'";
                count++;
            }
            if (equipmentToUpdate.image != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Images = '" + equipmentToUpdate.image + "'";
                count++;
            }
            if (equipmentToUpdate.operational != null )
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Number_Of_Tanks = '" + equipmentToUpdate.numberOfTanks + "'";
            }

            queryString += " Where Equipment.Equipment_ID = " + equipmentToUpdate.ID;

            string queryMessage = "Update equipment";
            string querySuccess = "Equipment has been updated.";
            string queryFail = "There was a problem, the equipment was not updated.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static void deleteEquipment(int ID)
        {
            string queryString = "delete from Equipment where Equipment.Equipment_ID = '" + ID.ToString() + "'";

            string message = "Delete equipment";
            string success = "Equipment has been deleted.";
            string fail = "There was a problem, the equipment was not deleted.";

            executeDelete(queryString, message, success, fail);
        }
        
        //FIELD
        public class farmField 
        {
            public int? ID { get; set; }
            public string field_Name { get; set; }
            public double? latitude { get; set; }
            public double? longitude { get; set; }
            public int? acres { get; set; }
            public string legalLandDescription { get; set; }
            public string fieldPerimeterCoordinates { get; set; }
            public bool? owned { get; set; }
            public string notes { get; set; }

            public farmField()
            {
                ID = null;
                field_Name = null;
                latitude = null;
                longitude = null;
                acres = null;
                legalLandDescription = null;
                fieldPerimeterCoordinates = null;
                owned = null;
                notes = null;
            }
        }
        public static void createField(farmField newField)
        {
            string queryString = "";
            string queryString1 = "insert into Fields (";
            string queryString2 = " values (";
            queryString1 += "Fields.Field_Name, ";
            queryString2 += "'" + newField.field_Name + "',";
            queryString1 += "Fields.Latitude, ";
            queryString2 += "'" + newField.latitude + "',";
            queryString1 += "Fields.Longitude, ";
            queryString2 += "'" + newField.longitude + "',";
            queryString1 += "Fields.Acres, ";
            queryString2 += "'" + newField.acres + "',";
            queryString1 += "Fields.Legal_Land_Description, ";
            queryString2 += "'" + newField.legalLandDescription + "',";
            queryString1 += "Fields.Field_Perimeter_Coodinates, ";
            queryString2 += "'" + newField.fieldPerimeterCoordinates + "',";
            queryString1 += "Fields.Owned";
            queryString2 += "'" + newField.owned + "'";

            if (newField.notes != null)
            {
                queryString1 += ", Fields.Notes";
                queryString2 += ",'" + newField.notes + "'";
            }

            queryString1 += ")";

            queryString = queryString1 + queryString2;

            string queryMessage = "Create field";
            string querySuccess = "Field has been created.";
            string queryFail = "There was a problem, the field was not created.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static string retreiveAllFields()
        {
            String queryString = "select * from Field ";

            string results = queryRetrieve(queryString);
            return results;
        }
        public static void updateField(farmField fieldToUpdate)
        {
            int count = 0;

            string queryString = "update Fields set ";

            if (fieldToUpdate.field_Name != null)
            {
                count++;
                queryString += "Equipment.Field_Name = '" + fieldToUpdate.field_Name + "'";
            }
            if (fieldToUpdate.latitude != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += " Equipment.Latitude = '" + fieldToUpdate.latitude + "'";
                count++;
            }
            if (fieldToUpdate.longitude != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Longitude = '" + fieldToUpdate.longitude + "'";
                count++;
            }
            if (fieldToUpdate.acres != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Acres = '" + fieldToUpdate.acres + "'";
                count++;
            }
            if (fieldToUpdate.legalLandDescription != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Legal_Land_Description = '" + fieldToUpdate.legalLandDescription + "'";
                count++;
            }
            if (fieldToUpdate.fieldPerimeterCoordinates != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Field_Perimeter_Coordinates = '" + fieldToUpdate.fieldPerimeterCoordinates + "'";
                count++;
            }
            if (fieldToUpdate.owned != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Owned = '" + fieldToUpdate.owned + "'";
                count++;
            }
            if (fieldToUpdate.notes != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Equipment.Notes = '" + fieldToUpdate.notes + "'";
            }

            queryString += " Where Equipment.Field_ID = " + fieldToUpdate.ID;

            string queryMessage = "Update field";
            string querySuccess = "Field has been updated.";
            string queryFail = "There was a problem, the field was not updated.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static void deleteField(int ID)
        {
            string queryString = "delete from Fields where Fields.Field_ID = '" + ID.ToString() + "'";

            string message = "Delete field";
            string success = "Field has been deleted.";
            string fail = "There was a problem, the field was not deleted.";

            executeDelete(queryString, message, success, fail);
        }

        //CROP
        public class farmCrop
        {
            public int? ID { get; set; }
            public string cropName { get; set; }
            public string species { get; set; }
            public string variety { get; set; }
            public string brand { get; set; }
            public string notes { get; set; }

            public farmCrop()
            {
                ID = null;
                cropName = null;
                species = null;
                variety = null;
                brand = null;
                notes = null;
            }
        }
        public static void createCrop(farmCrop newCrop)
        {
            string queryString = "";
            string queryString1 = "insert into Crops (";
            string queryString2 = " values (";
            queryString1 += "Crops.Crop_Name, ";
            queryString2 += "'" + newCrop.cropName + "',";
            queryString1 += "Crops.Species, ";
            queryString2 += "'" + newCrop.species + "',";
            queryString1 += "Crops.Variety, ";
            queryString2 += "'" + newCrop.variety + "',";
            queryString1 += "Crops.Brand, ";
            queryString2 += "'" + newCrop.brand + "'";

            if (newCrop.notes != null)
            {
                queryString1 += ", Crops.Notes";
                queryString2 += ",'" + newCrop.notes + "'";
            }

            queryString1 += ")";

            queryString = queryString1 + queryString2;

            string queryMessage = "Create crop";
            string querySuccess = "Crop has been created.";
            string queryFail = "There was a problem, the crop was not created.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static string retrieveAllCrops()
        {
            String queryString = "select * from Crop ";

            string results = queryRetrieve(queryString);
            return results;
        }
        public static string retrieveOneCrop(string ID)
        {
            String queryString = "select * from Crop where Crop.Crop_ID = '" + ID + "'";

            string results = queryRetrieve(queryString);
            return results;
        }
        public static void updateCrop(farmCrop cropToUpdate)
        {
            int count = 0;

            string queryString = "update crops set ";

            if (cropToUpdate.cropName != null)
            {
                count++;
                queryString += "Crop.crop_Name = '" + cropToUpdate.cropName + "'";
            }
            if (cropToUpdate.species != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += " Crop.species = '" + cropToUpdate.species + "'";
                count++;
            }
            if (cropToUpdate.variety != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Crop.variety = '" + cropToUpdate.variety + "'";
                count++;
            }
            if (cropToUpdate.brand != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Crop.brand = '" + cropToUpdate.brand + "'";
                count++;
            }
            if (cropToUpdate.notes != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Crop.brand = '" + cropToUpdate.brand + "'";
            }
           
            queryString += " Where Crop.Crop_ID = " + cropToUpdate.ID;

            string queryMessage = "Update crop";
            string querySuccess = "Crop has been updated.";
            string queryFail = "There was a problem, the crop was not updated.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static void deleteCrop(int ID)
        {
            string queryString = "delete from Crops where Crops.Crop_ID = '" + ID.ToString() + "'";

            string message = "Delete crop";
            string success = "Crop has been deleted.";
            string fail = "There was a problem, the crop was not deleted.";

            executeDelete(queryString, message, success, fail);
        }

        //CHEMICAL
        public class farmChemical
        {
            public int? ID { get; set; }
            public string chemicalName { get; set; }
            public string chemicalType { get; set; }
            public string brand { get; set; }
            public string notes { get; set; }

            public farmChemical()
            {
                ID = null;
                chemicalName = null;
                chemicalType = null;
                brand = null;
                notes = null;
            }
        }
        public static void createChemical(farmChemical newChemical)
        {
            string queryString = "";
            string queryString1 = "insert into Chemicals (";
            string queryString2 = " values (";
            queryString1 += "Chemicals.Chemical_Name, ";
            queryString2 += "'" + newChemical.chemicalName + "',";
            queryString1 += "Chemicals.chemicalType, ";
            queryString2 += "'" + newChemical.chemicalType + "',";
            queryString1 += "Chemicals.brand, ";
            queryString2 += "'" + newChemical.brand + "',";

            if (newChemical.notes != null)
            {
                queryString1 += ", Chemicals.Notes";
                queryString2 += ",'" + newChemical.notes + "'";
            }

            queryString1 += ")";

            queryString = queryString1 + queryString2;

            string queryMessage = "Create chemical";
            string querySuccess = "Chemical has been created.";
            string queryFail = "There was a problem, the chemical was not created.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static string retrieveAllChemicals()
        {
            String queryString = "select * from Chemical ";

            string results = queryRetrieve(queryString);
            return results;
        }
        public static string retrieveOneChemical(string ID)
        {
            String queryString = "select * from Chemical where Chemical.Chemical_ID = '" + ID + "'";

            string results = queryRetrieve(queryString);
            return results;
        }
        public static void updateChemical(farmChemical chemicalToUpdate)
        {
            int count = 0;

            string queryString = "update chemicals set ";

            if (chemicalToUpdate.chemicalName != null)
            {
                count++;
                queryString += "Chemical.chemical_Name = '" + chemicalToUpdate.chemicalName + "'";
            }
            if (chemicalToUpdate.chemicalType != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += " Chemical.chemicalType = '" + chemicalToUpdate.chemicalType + "'";
                count++;
            }
            if (chemicalToUpdate.brand != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Chemical.brand = '" + chemicalToUpdate.brand + "'";
                count++;
            }
            if (chemicalToUpdate.notes != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Chemical.notes = '" + chemicalToUpdate.notes + "'";
                count++;
            }
           
            queryString += " Where Chemical.chemical_ID = " + chemicalToUpdate.ID;

            string queryMessage = "Update chemical";
            string querySuccess = "Chemical has been updated.";
            string queryFail = "There was a problem, the chemical was not updated.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static void deleteChemical(int ID)
        {
            string queryString = "delete from Chemicals where Chemicals.Chemical_ID = '" + ID.ToString() + "'";

            string message = "Delete chemical";
            string success = "Chemical has been deleted.";
            string fail = "There was a problem, the chemical was not deleted.";

            executeDelete(queryString, message, success, fail);
        }

        //FARMING EVENT
        public class farmEvent
        {
            public int? ID { get; set; }
            public DateTime? Date { get; set; }
            public int? fieldID { get; set; }
            public int? operatorID { get; set; }
            public string activity{ get; set; }
            public int? tractorID { get; set; }
            public int? trailorID { get; set; }
            public int? acresWorked { get; set; }
            public int? primaryMediaID { get; set; }
            public int? primaryMediaQuantity { get; set; }
            public int? primaryMediaRate { get; set; }
            public int? secondaryMediaID { get; set; }
            public int? secondaryMediaQuantity { get; set; }
            public int? secondaryMediaRate{ get; set; }
            public int? tertiaryMediaID{ get; set; }
            public int? tertiaryMediaQuantity { get; set; }
            public int? tertiaryMediaRate { get; set; }
            public string yeildUnits { get; set; }
            public int? yeild { get; set; }
            public int? cropStageID { get; set; }
            public DateTime? dateOfEmergence { get; set; }
            public string notes { get; set; }
            public bool? planned { get; set; }

            public farmEvent()
            {
            ID = null;
            Date = null;
            fieldID = null;
            operatorID = null;
            activity = null;
            tractorID = null;
            trailorID = null;
            acresWorked = null;
            primaryMediaID = null;
            primaryMediaQuantity = null;
            primaryMediaRate = null;
            secondaryMediaID = null;
            secondaryMediaQuantity = null;
            secondaryMediaRate = null;
            tertiaryMediaID = null;
            tertiaryMediaQuantity = null;
            tertiaryMediaRate = null;
            yeildUnits = null;
            yeild = null;
            cropStageID = null;
            dateOfEmergence = null;
            notes = null;
            planned = null;
            }
        }
        public static void createFarmEvent(farmEvent newEvent)
        {
            string queryString = "";
            string queryString1 = "insert into Farming_Events (";
            string queryString2 = " values (";
            queryString1 += "Farming_Events.Date, ";
            queryString2 += "'" + newEvent.Date + "',";
            queryString1 += "Farming_Events.Field_ID, ";
            queryString2 += "'" + newEvent.fieldID+ "',";
            queryString1 += "Farming_Events.Operator_ID, ";
            queryString2 += "'" + newEvent.operatorID + "',";
            queryString1 += "Farming_Events.Activity ";
            queryString2 += "'" + newEvent.activity + "'";
            if (newEvent.tractorID != null)
            {
                queryString1 += ", Farming_Events.Tractor_Equipment_ID";
                queryString2 += ",'" + newEvent.tractorID + "'";
            }
            if (newEvent.trailorID != null)
            {
                queryString1 += ", Farming_Events.Trailor_Equipment_ID";
                queryString2 += ",'" + newEvent.trailorID + "'";
            }
            if (newEvent.acresWorked != null)
            {
                queryString1 += ", Farming_Events.Acres_Worked";
                queryString2 += ",'" + newEvent.acresWorked + "'";
            }
            if (newEvent.primaryMediaID != null)
            {
                queryString1 += ", Farming_Events.Primary_Media_ID";
                queryString2 += ",'" + newEvent.primaryMediaID + "'";
            }
            if (newEvent.primaryMediaQuantity != null)
            {
                queryString1 += ", Farming_Events.Primary_Media_Quantity";
                queryString2 += ",'" + newEvent.primaryMediaQuantity + "'";
            }
            if (newEvent.primaryMediaRate != null)
            {
                queryString1 += ", Farming_Events.Primary_Media_Rate";
                queryString2 += ",'" + newEvent.primaryMediaRate + "'";
            }
            if (newEvent.secondaryMediaID != null)
            {
                queryString1 += ", Farming_Events.Secondary_Media_ID";
                queryString2 += ",'" + newEvent.secondaryMediaID + "'";
            }
            if (newEvent.secondaryMediaQuantity != null)
            {
                queryString1 += ", Farming_Events.Secondary_Media_Quantity";
                queryString2 += ",'" + newEvent.secondaryMediaQuantity + "'";
            }
            if (newEvent.secondaryMediaRate != null)
            {
                queryString1 += ", Farming_Events.Secondary_Media_Rate";
                queryString2 += ",'" + newEvent.secondaryMediaRate+ "'";
            }
            if (newEvent.tertiaryMediaID != null)
            {
                queryString1 += ", Farming_Events.tertiary_Media_ID";
                queryString2 += ",'" + newEvent.tertiaryMediaID + "'";
            }
            if (newEvent.tertiaryMediaQuantity != null)
            {
                queryString1 += ", Farming_Events.tertiary_Media_Quantity";
                queryString2 += ",'" + newEvent.tertiaryMediaQuantity + "'";
            }
            if (newEvent.tertiaryMediaRate != null)
            {
                queryString1 += ", Farming_Events.tertiary_Media_Rate";
                queryString2 += ",'" + newEvent.tertiaryMediaRate + "'";
            }
            if (newEvent.yeildUnits != null)
            {
                queryString1 += ", Farming_Events.Yeild_Units";
                queryString2 += ",'" + newEvent.yeildUnits + "'";
            }
            if (newEvent.yeild != null)
            {
                queryString1 += ", Farming_Events.Yeild";
                queryString2 += ",'" + newEvent.yeild + "'";
            }
            if (newEvent.cropStageID != null)
            {
                queryString1 += ", Farming_Events.Crop_Stage_ID";
                queryString2 += ",'" + newEvent.cropStageID+ "'";
            }
            if (newEvent.tertiaryMediaID != null)
            {
                queryString1 += ", Farming_Events.tertiary_Media_ID";
                queryString2 += ",'" + newEvent.tertiaryMediaID + "'";
            }
            if (newEvent.dateOfEmergence != null)
            {
                queryString1 += ", Farming_Events.Date_Of_Emergence";
                queryString2 += ",'" + newEvent.dateOfEmergence + "'";
            }
            if (newEvent.notes != null)
            {
                queryString1 += ", Farming_Events.Notes";
                queryString2 += ",'" + newEvent.notes + "'";
            }
            
            queryString1 += ", Farming_Events.Planned";
            queryString2 += ",'" + newEvent.planned + "'";

            queryString = queryString1 + queryString2;

            string queryMessage = "Create farming event";
            string querySuccess = "Farming event has been created.";
            string queryFail = "There was a problem, the farming event was not created.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static string retrieveAllFarmEvents()
        {
            String queryString = "select * from Farming_Event ";

            string results = queryRetrieve(queryString);
            return results;
        }
        public static void updateFarmEvent(farmEvent eventToUpdate)
        {
            int count = 0;

            string queryString = "update Farming_Events set ";

            if (eventToUpdate.Date != null)
            {
                count++;
                queryString += "Farming_Events.Date = '" + eventToUpdate.Date + "'";
            }
            if (eventToUpdate.fieldID != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += " Farming_Events.Field_ID = '" + eventToUpdate.fieldID + "'";
                count++;
            }
            if (eventToUpdate.operatorID != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Operator_ID = '" + eventToUpdate.operatorID + "'";
                count++;
            }
            if (eventToUpdate.activity != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Activity = '" + eventToUpdate.activity + "'";
                count++;
            }
            if (eventToUpdate.tractorID != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Tractor_Equipment_ID = '" + eventToUpdate.tractorID + "'";
                count++;
            }
            if (eventToUpdate.trailorID != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Trailor_Equipment_ID = '" + eventToUpdate.trailorID + "'";
                count++;
            }
            if (eventToUpdate.acresWorked != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Acres_Worked = '" + eventToUpdate.acresWorked + "'";
                count++;
            }
            if (eventToUpdate.primaryMediaID != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Primary_Media_ID = '" + eventToUpdate.primaryMediaID + "'";
                count++;
            }
            if (eventToUpdate.primaryMediaQuantity != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Primary_Media_Quantity = '" + eventToUpdate.primaryMediaQuantity + "'";
                count++;
            }
            if (eventToUpdate.primaryMediaRate != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Primary_Media_Rate = '" + eventToUpdate.primaryMediaRate + "'";
                count++;
            }
            if (eventToUpdate.secondaryMediaID != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Secondary_Media_ID = '" + eventToUpdate.secondaryMediaID + "'";
                count++;
            }
            if (eventToUpdate.secondaryMediaQuantity != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Secondary_Media_Quantity = '" + eventToUpdate.secondaryMediaQuantity + "'";
                count++;
            }
            if (eventToUpdate.secondaryMediaRate != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Secondary_Media_Rate = '" + eventToUpdate.secondaryMediaRate + "'";
                count++;
            }
            if (eventToUpdate.tertiaryMediaID != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Tertiary_Media_ID = '" + eventToUpdate.tertiaryMediaID + "'";
                count++;
            }
            if (eventToUpdate.tertiaryMediaQuantity != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Tertiary_Media_Quantity = '" + eventToUpdate.tertiaryMediaQuantity + "'";
                count++;
            }
            if (eventToUpdate.tertiaryMediaRate != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Tertiary_Media_Rate = '" + eventToUpdate.tertiaryMediaRate + "'";
                count++;
            }
            if (eventToUpdate.yeildUnits != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Yeild_Units = '" + eventToUpdate.yeildUnits + "'";
                count++;
            }
            if (eventToUpdate.yeild != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Yeild = '" + eventToUpdate.yeild + "'";
                count++;
            }
            if (eventToUpdate.cropStageID != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Crop_Stage_ID = '" + eventToUpdate.cropStageID + "'";
                count++;
            }
            if (eventToUpdate.dateOfEmergence != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Date_Of_Emergence = '" + eventToUpdate.dateOfEmergence + "'";
                count++;
            }
            if (eventToUpdate.notes != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Notes = '" + eventToUpdate.notes + "'";
                count++;
            }
            if (eventToUpdate.planned != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Farming_Events.Planned = '" + eventToUpdate.planned + "'";
                count++;
            }
            if (count >= 1)
            {
                queryString += ",";
            }
            queryString += " Where Farming_Events.event_ID = " + eventToUpdate.ID;

            string queryMessage = "Update event";
            string querySuccess = "Event has been updated.";
            string queryFail = "There was a problem, the event was not updated.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static void deleteFarmEvent(int ID)
        {
            string queryString = "delete from Farming_Events where Farming_Events.Farming_Event_ID = '" + ID.ToString() + "'";

            string message = "Delete farming event";
            string success = "Farming event has been deleted.";
            string fail = "There was a problem, the farming event was not deleted.";

            executeDelete(queryString, message, success, fail);
        }

        //BREAKDOWNS
        public class farmBreakdowns
        {
            public int? ID { get; set; }
            public int? equipmentID { get; set; }
            public int? operatorID { get; set; }
            public DateTime? date { get; set; }
            public string description { get; set; }
            public string notes { get; set; }
            public bool? repaired { get; set; }
            public DateTime? dateRepaired { get; set; }

            public farmBreakdowns()
            {
                ID = null;
                equipmentID = null;
                operatorID = null;
                date = null;
                description = null;
                notes = null;
                repaired = null;
                dateRepaired = null;
            }
        }
        public static void createBreakdown(farmBreakdowns newBreakdown)
        {
            string queryString = "";
            string queryString1 = "insert into Breakdowns (";
            string queryString2 = " values (";
            queryString1 += "Breakdowns.Breakdown_ID, ";
            queryString2 += "'" + newBreakdown.ID + "',";
            queryString1 += "Breakdowns.Equipment_ID, ";
            queryString2 += "'" + newBreakdown.equipmentID + "',";
            queryString1 += "Breakdowns.Operator_ID, ";
            queryString2 += "'" + newBreakdown.operatorID + "',";
            queryString1 += "Breakdowns.Date ";
            queryString2 += "'" + newBreakdown.date + "',";
            queryString1 += "Breakdowns.Description ";
            queryString2 += "'" + newBreakdown.description + "'";
            if (newBreakdown.notes != null)
            {
                queryString1 += ", Breakdowns.Notes";
                queryString2 += ",'" + newBreakdown.notes + "'";
            }
            if (newBreakdown.repaired != null)
            {
                queryString1 += ", Breakdowns.Repaired";
                queryString2 += ",'" + newBreakdown.repaired + "'";
            }
            if (newBreakdown.dateRepaired != null)
            {
                queryString1 += ", Breakdowns.Date_Repaired";
                queryString2 += ",'" + newBreakdown.dateRepaired + "'";
            }

            queryString = queryString1 + queryString2;

            string queryMessage = "Create breakdown";
            string querySuccess = "Breakdown has been created.";
            string queryFail = "There was a problem, the breakdown was not created.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static string retrieveAllBreakdowns()
        {
            String queryString = "select * from Breakdowns ";

            string results = queryRetrieve(queryString);
            return results;
        }
        public static string retrieveOneEquipmentBreakdowns(string ID)
        {
            String queryString = "select * from Breakdowns where Equipment_ID = " + ID;

            string results = queryRetrieve(queryString);
            return results;
        }
        public static void updateBreakdown(farmBreakdowns breakdownToUpdate)
        {
            int count = 0;

            string queryString = "update Breakdowns set ";

            if (breakdownToUpdate.equipmentID != null)
            {
                count++;
                queryString += "Breakdowns.Equipment_ID = '" + breakdownToUpdate.equipmentID + "'";
            }
            if (breakdownToUpdate.operatorID != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += " Breakdowns.Operator_ID = '" + breakdownToUpdate.operatorID + "'";
                count++;
            }
            if (breakdownToUpdate.date != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += " Breakdowns.Date = '" + breakdownToUpdate.date + "'";
                count++;
            }
            if (breakdownToUpdate.description != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Breakdowns.Description = '" + breakdownToUpdate.description + "'";
                count++;
            }
            if (breakdownToUpdate.notes != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Breakdowns.Notes = '" + breakdownToUpdate.notes+ "'";
                count++;
            }
            if (breakdownToUpdate.repaired != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Breakdowns.Repaired = '" + breakdownToUpdate.repaired + "'";
                count++;
            }
            if (breakdownToUpdate.dateRepaired != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "Breakdowns.Date_Repaired = '" + breakdownToUpdate.dateRepaired + "'";
                count++;
            }

            queryString += " Where Breakdowns.breakdown_ID = " + breakdownToUpdate.ID;

            string queryMessage = "Update breakdown";
            string querySuccess = "breakdown has been updated.";
            string queryFail = "There was a problem, the breakdown was not updated.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static void deleteBreakdown(int ID)
        {
            string queryString = "delete from Breakdowns where Breakdowns.Breakdown_ID = '" + ID.ToString() + "'";

            string message = "Delete breakdown";
            string success = "Breakdown has been deleted.";
            string fail = "There was a problem, the breakdown was not deleted.";

            executeDelete(queryString, message, success, fail);
        }

        //HISTORY
        public class farmHistory
        {
             public int? ID { get; set; }
             public int? year { get; set; }
             public int? fieldID { get; set; }
             public int? cropID { get; set; }
             public int? totalPlanted { get; set; }
             public int? totalYeild { get; set; }
             public DateTime? dateOfEmergence { get; set; }

             public farmHistory()
             {
                 ID = null;
                 year = null;
                 fieldID = null;
                 cropID = null;
                 totalPlanted = null;
                 totalYeild = null;
                 dateOfEmergence = null;
             }
        }
        public static void createHistory(farmHistory newHistory)
        {
            string queryString = "";
            string queryString1 = "insert into History (";
            string queryString2 = " values (";
            queryString1 += "History.Year, ";
            queryString2 += "'" + newHistory.year + "',";
            queryString1 += "History.Field_ID, ";
            queryString2 += "'" + newHistory.fieldID + "',";
            queryString1 += "History.Crop_ID, ";
            queryString2 += "'" + newHistory.cropID + "',";
            queryString1 += "History.Total_Planted, ";
            queryString2 += "'" + newHistory.totalPlanted + "'";
            queryString1 += "History.Total_Yeild, ";
            queryString2 += "'" + newHistory.totalYeild + "'";

            if (newHistory.dateOfEmergence != null)
            {
                queryString1 += ", History.Date_Of_Emergence";
                queryString2 += ",'" + newHistory.dateOfEmergence + "'";
            }

            queryString1 += ")";

            queryString = queryString1 + queryString2;

            string queryMessage = "Create history";
            string querySuccess = "History has been created.";
            string queryFail = "There was a problem, the history was not created.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static string retrieveAllHistory()
        {
            String queryString = "select * from History ";

            string results = queryRetrieve(queryString);
            return results;
        }
        public static void updateHistory(farmHistory historyToUpdate)
        {
            int count = 0;

            string queryString = "update History set ";

            if (historyToUpdate.year != null)
            {
                count++;
                queryString += "History.Year = '" + historyToUpdate.year + "'";
            }
            if (historyToUpdate.fieldID != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += " History.Field_ID = '" + historyToUpdate.fieldID + "'";
                count++;
            }
            if (historyToUpdate.cropID != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += " History.Crop_ID = '" + historyToUpdate.cropID + "'";
                count++;
            }
            if (historyToUpdate.totalPlanted != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "History.Total_Planted = '" + historyToUpdate.totalPlanted + "'";
                count++;
            }
            if (historyToUpdate.totalYeild != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "History.Total_Yeild = '" + historyToUpdate.totalYeild + "'";
                count++;
            }
            if (historyToUpdate.dateOfEmergence != null)
            {
                if (count >= 1)
                {
                    queryString += ",";
                }
                queryString += "History.Date_Of_Emergence = '" + historyToUpdate.dateOfEmergence + "'";
                count++;
            }

            queryString += " Where History.History_ID = " + historyToUpdate.ID;

            string queryMessage = "Update history";
            string querySuccess = "History has been updated.";
            string queryFail = "There was a problem, the history was not updated.";

            queryExecute(queryString, queryMessage, querySuccess, queryFail);
        }
        public static void deleteHistory(int ID)
        {
            string queryString = "delete from History where History.History_ID = '" + ID.ToString() + "'";

            string message = "Delete history";
            string success = "History has been deleted.";
            string fail = "There was a problem, the history was not deleted.";

            executeDelete(queryString, message, success, fail);
        }
        //RAIN GUAGE

        private static string queryRetrieve(string queryString)
        {
            DataTable dt = new DataTable();
            List<object> searchItems = new List<object>();
            string results = "";
            using (SqlConnection con = new SqlConnection(Global_Variables.CONNECTIONSTRING))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryString, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                Dictionary<string, object> row;
                foreach (DataRow dr in dt.Rows)
                {
                    row = new Dictionary<string, object>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        row.Add(col.ColumnName, dr[col]);
                    }
                    rows.Add(row);
                }
                results = serializer.Serialize(rows);
                
                con.Close();
            }
            return results;
        }
        private static void queryExecute(string insertString, string queryMessage, string successMessage, string failMessage)
        {

            MessageBox.Show("In queryExecute... - " + insertString);

            using (SqlConnection myconnection = new SqlConnection(Global_Variables.CONNECTIONSTRING))
            {

                myconnection.Open();

                SqlCommand mycommand = myconnection.CreateCommand();
                SqlTransaction mytransaction;

                mytransaction = myconnection.BeginTransaction(queryMessage);

                mycommand.Connection = myconnection;
                mycommand.Transaction = mytransaction;

                try
                {
                    mycommand.CommandText = insertString;
                    mycommand.ExecuteNonQuery();

                    // Attempt to commit the transaction. 
                    mytransaction.Commit();
                    MessageBox.Show(successMessage);
                    myconnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(failMessage);
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    // Attempt to roll back the transaction.  
                    try
                    {
                        mytransaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred  
                        // on the server that would cause the rollback to fail, such as  
                        // a closed connection. 
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
            return;
        }
        private static void executeDelete(string queryString, string message, string success, string fail)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently remove this from the database?", message, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                queryExecute(queryString, message, success, fail);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
