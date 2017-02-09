﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drilling
{
    public class Question
    {
        private int id;
        private Theme belongsTo;
        private String texte;
        private String memo;

        public Theme BelongsTo
        {
            get
            {
                return belongsTo;
            }
        }

        public String Texte
        {
            get
            {
                return texte;
            }
        }

        public String Memo
        {
            get
            {
                return memo;
            }
        }

        public Question(Theme belongsTo, String texte, String memo)
        {
            this.belongsTo = belongsTo;
            this.texte = texte;
            this.memo = memo;
        }
    }
}
