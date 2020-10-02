using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic.Strategies
{
    public class FetchAlbumsFromAPIStrategy : IFetchStrategy
    {
        public AlbumsModel AlbumsModel { get; set; }

        public void FetchData()
        {
            AlbumsModel.Albums.Clear();
            foreach (Album album in AlbumsModel.User.Albums)
            {
                AlbumsModel.Albums.Add(album);
            }
        }
    }
}
