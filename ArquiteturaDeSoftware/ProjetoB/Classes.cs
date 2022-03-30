﻿using ProjetoA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoB
{
    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            //var privada = new Privada();
            //var interna = new Interna();
            //var abstrata = new Abstrata();
        }

        class TesteModificador1
        {
            public TesteModificador1()
            {
                var publica = new Publica();

                publica.TestePublico();
                //publica.TesteInternal();
                //publica.TesteProtegidoInterno();
                //publica.TesteProtegido();
                //publica.TestePrivadoProtegido();
                //publica.TestePrivado();
            }
        }

        class TesteModificador2 : Publica
        {
            public TesteModificador2()
            {
                TestePublico();
                TesteProtegido();
                TesteProtegidoInterno();
                //TesteInternal();
                //TestePrivadoProtegido();
                //TestePrivado();
            }
        }
    }
}
