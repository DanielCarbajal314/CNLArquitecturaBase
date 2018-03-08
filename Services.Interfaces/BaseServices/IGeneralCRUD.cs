using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.BaseServices
{
    public interface IGeneralCRUD<TCreationRequestDTO, TUpdateRequestDTO, TGeneralResponseDTO>
    {
        TGeneralResponseDTO Create(TCreationRequestDTO creationRequest);
        List<TGeneralResponseDTO> List();
        TGeneralResponseDTO Update(TUpdateRequestDTO registroParaActualizar);
        void Delete(int registerId);
    }
}
