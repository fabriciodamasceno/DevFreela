using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace DevFreela.Core.Entities
{
    public class ProjectComment : BaseEntity;
    {
        public ProjectComment(string content, int IdProject, int idUser) 
        {
            Content = content;
            IdUser = idUser;
            IdProject = IdProject;
   
        }
        public string Content { get; private set; }
        public int IdProject { get; private set; }
        public int IdUser { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}