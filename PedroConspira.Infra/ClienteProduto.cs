//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PedroConspira.Infra
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClienteProduto
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
