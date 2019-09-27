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

        public string MessageBody { get; set; }

        public InformationBoardListViewModel(Models.InformationBoard informationBoard)
        {
            this.Id = informationBoard.Id;
            this.HeadLine = informationBoard.HeadLine;
            this.MessageBody = informationBoard.MessageBody;
        }
    }
}
