namespace Atividade1.Models
{
    public class Variaveis
    {
        // Tipos implicitos
        // var teste = 10;
        // Anotação de Tipos


        public sbyte SByteMin => sbyte.MinValue;
        public sbyte SByteMax => sbyte.MaxValue;

        public byte ByteMin => byte.MinValue;
        public byte ByteMax => byte.MaxValue;

        public short ShortMin => short.MinValue;
        public short ShortMax => short.MaxValue;

        public ushort UShortMin => ushort.MinValue;
        public ushort UShortMax => ushort.MaxValue;

        public int IntMin => int.MinValue;
        public int IntMax => int.MaxValue;

        public uint UIntMin => uint.MinValue;
        public uint UIntMax => uint.MaxValue;

        public long LongMin => long.MinValue;
        public long LongMax => long.MaxValue;

        public ulong ULongMin => ulong.MinValue;
        public ulong ULongMax => ulong.MaxValue;

        public float FloatMin => float.MinValue;
        public float FloatMax => float.MaxValue;

        public double DoubleMin => double.MinValue;
        public double DoubleMax => double.MaxValue;

        public decimal DecimalMin => decimal.MinValue;
        public decimal DecimalMax => decimal.MaxValue;
        // COnSTANTES
        // Para declarar uma constante utilizamos a palavra-chave CONST
        // No entanto a CONST deve ser inicializada quando declarada
        const int interestRate = 10;


        // O método construtor é invocada na instanciação do objet por meio da 
        // palavra reservada new
        // Por regra, o construtor sempre tem o mesmo nome da classe

    }
}
