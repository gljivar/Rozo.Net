using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.DTO
{
    public class QuestionDTO : IDTO
    {
        public int Id
        {
            get;
            set;
        }

        public string Question
        {
            get;
            set;
        }

        public int? Category
        {
            get;
            set;
        }

        public UserDTO AddedBy
        {
            get;
            set;
        }

        public bool Solved
        {
            get;
            set;
        }

        public bool Open
        {
            get;
            set;
        }

        public bool MultipleSolutions
        {
            get;
            set;
        }

        public List<ProvidedAnswerDTO> ProvidedAnswers
        {
            get;
            set;
        }

        public List<TagDTO> Tags
        {
            get;
            set;
        }

        public List<SolutionDTO> Solutions
        {
            get;
            set;
        }
    }
}
