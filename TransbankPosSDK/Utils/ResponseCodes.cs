﻿using System.Collections.Generic;

namespace Transbank.POS.Utils
{
    public static class ResponseCodes
    {
        public static readonly Dictionary<int, string> Map = new Dictionary<int, string>
        {
            {00, "Aprobado"},
            {01, "Rechazado"},
            {02, "Host no responde"},
            {03, "Conexión falló"},
            {04, "Transacción ya fue anulada"},
            {05, "No existe transacción para anular"},
            {06, "Tarjeta no soportada"},
            {07, "Transacción cancelada desde el POS"},
            {08, "No puede anular transacción débito"},
            {09, "Error lectura tarjeta"},
            {10, "Monto menor al mínimo permitido"},
            {11, "No existe venta"},
            {12, "Transacción no soportada"},
            {13, "Debe ejecutar cierre "},
            {14, "No hay tono"},
            {15, "Archivo BITMAP.DAT no encontrado. favor cargue"},
            {16, "Error formato respuesta del host"},
            {17, "Error en los 4 últimos dígitos."},
            {18, "Menú invalido"},
            {19, "ERROR_TARJ_DIST"},
            {20, "Tarjeta inválida"},
            {21, "Anulación no permitida"},
            {22, "TIMEOUT"},
            {24, "Impresora sin papel"},
            {25, "Fecha inválida"},
            {26, "Debe cargar llaves"},
            {27, "Debe actualizar"},
            {54, "Rechazado" },
            {60, "Error en número de cuotas"},
            {61, "Error en armado de solicitud"},
            {62, "Problema con el pinpad interno"},
            {65, "Error al procesar la respuesta del host"},
            {67, "Superó número máximo de ventas, debe ejecutar cierre"},
            {68, "Error genérico, falla al ingresar montos"},
            {70, "Error de formato campo de boleta MAX 6"},
            {71, "Error de largo campo de impresión"},
            {72, "Error de monto venta, debe ser mayor que 0"},
            {73, "Terminal ID no configurado"},
            {74, "Debe ejecutar cierre"},
            {75, "Comercio no tiene tarjetas configuradas"},
            {76, "Superó número máximo de ventas, debe ejecutar cierre"},
            {77, "Debe ejecutar cierre"},
            {78, "Esperando leer tarjeta"},
            {79, "Solicitando confirmar monto"},
            {80, "Esperando selección de cuotas"},
            {81, "Solicitando ingreso de clave"},
            {82, "Enviando transacción al host"},
            {88, "Error cantidad cuotas"},
            {93, "Declinada"},
            {94, "Error al procesar respuesta"},
            {95, "Error al imprimir TASA"}
        };
    }
}
