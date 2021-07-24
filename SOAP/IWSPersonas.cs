using System.Runtime.Serialization;
using System.ServiceModel;

namespace Soap
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSPersonas
    {

        [OperationContract]
        Persona GetPersona(string id);

       
       
        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
   
    [DataContract]
    public class Persona : BaseResponse
    {
        [DataMember]
        public string Nombre { get; set;}
        [DataMember]
        public int Edad { get; set; }
    }

    [DataContract]
    public class BaseResponse
    {
        [DataMember]
        public string MensajeRespuesta { get; set; }

        [DataMember]
        public string Error { get; set; }
    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
