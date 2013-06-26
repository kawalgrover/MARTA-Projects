using System.ServiceModel;

namespace PaperlessBoardServices
{
    [ServiceContract]
    public interface IPaperlessBoard
    {
        [OperationContract]
        string HelloWorld();

        [OperationContract]
        void PublishAgendaToBoard(int agendaID);
        

    }
}

