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
        [DisplayName("Message HeadLine")]
        public string HeadLine { get; set; }

        [DisplayName("Message Body")]
        public string MessageBody { get; set; }

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
                MessageBody = this.MessageBody
            };
            repositoryFactory.GetInformationBoardRepository().Save(informationBoard);
        }
    }
}
