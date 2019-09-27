using CommunityOrganizer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityOrganizer.ViewModels.InformationBoard
{
    public class InformationBoardEditViewModel
    {
        [DisplayName("Meassage HeadLine")]
        public string HeadLine { get; set; }

        [DisplayName("Message Body")]
        public  string MessageBody { get; set; }

        public InformationBoardEditViewModel()
        {

        }

        public InformationBoardEditViewModel(int id)
        {

        }

        public InformationBoardEditViewModel(int id, Factory repositoryFactory)
        {
            Models.InformationBoard informationBoard = repositoryFactory.GetInformationBoardRepository().GetById(id);
            this.HeadLine = informationBoard.HeadLine;
            this.MessageBody = informationBoard.MessageBody;
        }

        public void Persist(int id, Factory repositoryFactory)
        {
            Models.InformationBoard informationBoard = new Models.InformationBoard
            {
                HeadLine = this.HeadLine,
                MessageBody = this.MessageBody
            };

            repositoryFactory.GetInformationBoardRepository().Update(informationBoard);
        }

    }
}
