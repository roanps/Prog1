namespace Atividade1.Models
{
    public class Variaveis
    {
        // Tipos implicitos
        // var teste = 10;
        // Anotação de Tipos

        public int minInt = -2147483648;
        //Uma variável pode ser declarada e não inicializada
        public int maxInt;

        public byte minByte = 0;
        public byte maxByte = 255;
        public sbyte minSbyte = -128;
        public sbyte maxSbyte = 127;
        public short minShort = -32768;
        public short maxShort = 32767;
        public ushort minUshort = 0;
        public ushort maxUshort = 65535;
        public uint minUint = 0;
        public uint maxUint = 4292967295;
        public long minLong = -9223372036854775808;
        public long maxLong = 9223372036854775807;
        public ulong minUlong = -0;
        public ulong maxUlong = 18446744073709551615;

        // COnSTANTES
        // Para declarar uma constante utilizamos a palavra-chave CONST
        // No entanto a CONST deve ser inicializada quando declarada
        const int interestRate = 10;


        // O método construtor é invocada na instanciação do objet por meio da 
        // palavra reservada new
        // Por regra, o construtor sempre tem o mesmo nome da classe


        public Variaveis()
        {
            maxInt = 2147483647;

            // Tipo implicito, a palavra chave var se encarrega de definir o
            // tipo da variável na instrução de atribuição
           // var signalStrength = 22;
          //  var companyName = "ACME";

        }
    }
}
