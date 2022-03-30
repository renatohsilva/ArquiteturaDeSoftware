using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA
{
    #region Classes

    public class Publica
    {
        /// <summary>
        /// Access is not restricted.
        /// </summary>
        public void TestePublico() { }

        /// <summary>
        /// Access is limited to the containing type.
        /// </summary>
        private void TestePrivado() { }

        /// <summary>
        /// Access is limited to the current assembly.
        /// </summary>
        internal void TesteInternal() { }

        /// <summary>
        /// Access is limited to the containing class or types
        /// derived from the containing class.
        /// </summary>
        protected void TesteProtegido() { }

        /// <summary>
        /// Access is limited to the containing class or types derived 
        /// from the containing class within the current assembly.
        /// Available since C# 7.2.
        /// </summary>
        private protected void TestePrivadoProtegido() { }

        /// <summary>
        /// Access is limited to the current assembly or types
        /// derived from the containing class.
        /// </summary>
        protected internal void TesteProtegidoInterno() { }
    }

    public sealed class Selada { }

    class Privada { }

    /// <summary>
    /// internal:
    /// Access is limited to the current assembly.
    /// </summary>
    internal class Interna { }

    abstract class Abstrata { }

    #endregion

    #region Testes

    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            var privada = new Privada();
            var interna = new Interna();
            //var abstrata = new Abstrata();
        }
    }

    //class TesteSelada : Selada { }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            publica.TesteInternal();
            publica.TesteProtegidoInterno();
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
            TesteInternal();
            TesteProtegido();
            TesteProtegidoInterno();
            TestePrivadoProtegido();
            //TestePrivado();
        }
    }

    #endregion
}
