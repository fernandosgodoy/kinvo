using Kinvo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kinvo.Infra.Data.Mappings
{
    internal class ProdutoMap
        : MapBase<Produto>
    {

        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);
            builder.ToTable("produtos");
            //builder.HasKey(c => c.Id);
            //builder.Property(c => c.Id).IsRequired().HasField("Id");
            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(50);
            builder.Property(c => c.Instituicao).IsRequired().HasColumnName("Instituicao").HasMaxLength(30);
            builder.Property(c => c.AtivoSigla).HasColumnName("AtivoSigla").HasMaxLength(8);
            builder.Property(c => c.Qtde).IsRequired().HasColumnName("Qtde");
            builder.Property(c => c.PrecoCompra).IsRequired().HasColumnName("PrecoCompra");
            builder.Property(c => c.DataInicio).IsRequired().HasColumnName("DataInicio");
            builder.Property(c => c.TaxaCorretagem).HasColumnName("TaxaCorretagem");
            builder.Property(c => c.TaxaAnual).HasColumnName("TaxaAnual");
            builder.Property(c => c.CategoriaProduto).IsRequired().HasColumnName("CategoriaProduto");

        }

    }
}
