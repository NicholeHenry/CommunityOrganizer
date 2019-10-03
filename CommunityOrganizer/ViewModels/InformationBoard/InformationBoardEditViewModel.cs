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
        [DisplayName("Message Headline")]
        public string HeadLine { get; set; }

        [DisplayName("Message Headline Two")]
        public string HeadLineTwo { get; set; }

        [DisplayName("Message HeadLine Three")]
        public string HeadLineThree { get; set; }

        [DisplayName("Message Body")]
        public  string MessageBody { get; set; }

        [DisplayName("Message Body Two")]
        public string MessageBodytwo { get; set; }

        [DisplayName("Message Body Three")]
        public string MessageBodythree { get; set; }

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
            this.HeadLineTwo = informationBoard.HeadLineTwo;
            this.HeadLineThree = informationBoard.HeadLineThree;
            this.MessageBody = informationBoard.MessageBody;
            this.MessageBodytwo = informationBoard.MessageBodytwo;
            this.MessageBodythree = informationBoard.MessageBodythree;
        }

        public void Persist(int id, Factory repositoryFactory)
        {
            Models.InformationBoard informationBoard = new Models.InformationBoard
            {
                HeadLine = this.HeadLine,
                HeadLineTwo = this.HeadLineTwo,
                HeadLineThree = this.HeadLineThree,
                MessageBody = this.MessageBody,
                MessageBodytwo = this.MessageBodytwo,
                MessageBodythree = this.MessageBodythree
            };

            repositoryFactory.GetInformationBoardRepository().Update(informationBoard);
        }

    }
}
