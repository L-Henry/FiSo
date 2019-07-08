using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Fiets : IKanRijden, IkKanRemmen, IIkKanWheelieDoen
    {
        public void Remmen()
        {
            throw new NotImplementedException();
        }

        public void Rijden()
        {
            throw new NotImplementedException();
        }

        public void Wheelie()
        {
            throw new NotImplementedException();
        }
    }
}
