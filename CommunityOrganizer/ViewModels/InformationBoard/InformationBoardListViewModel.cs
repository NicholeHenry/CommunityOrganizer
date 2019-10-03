using CommunityOrganizer.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityOrganizer.ViewModels.InformationBoard
{
    public class InformationBoardListViewModel
    {

        public static List<InformationBoardListViewModel>GetInformationBoard(Factory repositoryFactory)
        {

            return repositoryFactory.GetInformationBoardRepository()
                .GetModels()
                .Select(info => new InformationBoardListViewModel(info))
                .ToList();
        }

        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public string HeadLine { get; set; }

        public string HeadLineTwo { get; set; }

        public string HeadLineThree { get; set; }

        public string MessageBody { get; set; }
        public string MessageBodytwo { get; set; }
        public string MessageBodythree { get; set; }

        public InformationBoardListViewModel(Models.InformationBoard informationBoard)
        {
            this.Id = informationBoard.Id;
            this.HeadLine = informationBoard.HeadLine;
            this.HeadLineTwo = informationBoard.HeadLineTwo;
            this.HeadLineThree = informationBoard.HeadLineTwo;
          
            this.MessageBody = informationBoard.MessageBody;
            this.MessageBodytwo = informationBoard.MessageBodytwo;
            this.MessageBodythree = informationBoard.MessageBodythree;
        }
    }
}
