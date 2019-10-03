using CommunityOrganizer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityOrganizer.ViewModels.InformationBoard
{
    public class InformationBoardCreateViewModel
    {
        [DisplayName("Message Headline")]
        public string HeadLine { get; set; }
        
        [DisplayName("Message Headline Two")]
        public string HeadLineTwo { get; set; }
        
        [DisplayName("Message Headline Three")]
        public string HeadLineThree { get; set; }

        [DisplayName("Message Body")]
        public string MessageBody { get; set; }

        [DisplayName("Message Body two")]
        public string MessageBodytwo { get; set; }

        [DisplayName("Message Body three")]
        public string MessageBodythree { get; set; }
        public InformationBoardCreateViewModel()
        {

        }

        public InformationBoardCreateViewModel(Factory repositoryFactory)
        {

        }

        public void Persist(Factory repositoryFactory)
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
            repositoryFactory.GetInformationBoardRepository().Save(informationBoard);
        }
    }
}
