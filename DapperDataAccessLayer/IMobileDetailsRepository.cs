using System;
using System.Collections.Generic;

namespace DapperDataAccessLayer
{
    public interface IMobileDetailsRepository
    {
        public MobileDetail InsertSP(MobileDetail MD);
        public IEnumerable<MobileDetail> ReadSP();
        public MobileDetail DeleteRecordSP(long id);
        public MobileDetail UpdateSP(long id, MobileDetail MDS);

    }
}
