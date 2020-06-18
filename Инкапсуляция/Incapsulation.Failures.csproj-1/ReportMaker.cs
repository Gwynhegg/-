using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Failures
{

    public class Common
    {
        public static int IsFailureSerious(int failureType)
        {
            if (failureType%2==0) return 1;
            return 0;
        }


        public static int Earlier(object[] v, int day, int month, int year)
        {
            int vYear = (int)v[2];
            int vMonth = (int)v[1];
            int vDay = (int)v[0];
            if (vYear < year) return 1;
            if (vYear > year) return 0;
            if (vMonth < month) return 1;
            if (vMonth > month) return 0;
            if (vDay < day) return 1;
            return 0;
        }
    }

    public class ReportMaker
    {
        /// <summary>
        /// </summary>
        /// <param name="day"></param>
        /// <param name="failureTypes">
        /// 0 for unexpected shutdown, 
        /// 1 for short non-responding, 
        /// 2 for hardware failures, 
        /// 3 for connection problems
        /// </param>
        /// <param name="deviceId"></param>
        /// <param name="times"></param>
        /// <param name="devices"></param>
        /// <returns></returns>
        /// 

        //Передаются значения о Device, содержащие ID и Name, а также даты возникновения ошибки times. *Создать класс Device*
        //Также замечено, что массив deviceId полностью копирует соответствующие значения Device.Id, следовательно, может быть упразднен.
        //Чтобы сократить количество параметров, передаваемых методу, можно создать вспомогательный класс Deadline, куда уйдут day, month и year.
        public static List<string> FindDevicesFailedBeforeDateObsolete(
            int day,
            int month,
            int year,
            int[] failureTypes, 
            int[] deviceId, 
            object[][] times,
            List<Dictionary<string, object>> devices)
        {
            //Новый код, использующий принципы ООП и инкапсуляцию.
            Deadline date = new Deadline(); //Создаем экземпляр даты
            date.setDay(day); date.setMonth(month); date.setYear(year); //Устанавливаем дедлайн.
            Device[] new_devices = new Device[deviceId.Length]; //Создаем массив девайсов
            for (int i = 0; i < deviceId.Length; i++) //Создаем экземпляры класса Device для передачи в метод.
                new_devices[i] = new Device(deviceId[i], devices[i]["Name"] as string, times[i], failureTypes[i]); //используем конструктор для передачи значений (геттеры и сеттеры также присутствуют)
            return FindDevicesFailedBeforeDate(date, new_devices);
            
            //Старый код для проверки результата. Недостижим.
            var problematicDevices = new HashSet<int>();
            for (int i = 0; i < failureTypes.Length; i++) //Также непонятно, почему мы используем цикл по типам ошибок, когда необходимо использовать его по количеству устройств
                if (Common.IsFailureSerious(failureTypes[i])==1 && Common.Earlier(times[i], day, month, year)==1)
                    problematicDevices.Add(deviceId[i]);

            var result = new List<string>();
            foreach (var device in devices) //Предназначение данного цикла также непонятно, поскольку необходимо лишь вывести все имена девайсов, Id которых есть в хэшсете.
                if (problematicDevices.Contains((int)device["DeviceId"]))
                    result.Add(device["Name"] as string);

            return result;
        }

        //Новый метод, включающий в себя классы Device, Deadline и Failure
        //Данный метод можно вызывать напрямую, создавая экземпляры приведенных классов
        public static List<string> FindDevicesFailedBeforeDate(Deadline date, Device[] devices)
        {
            var result = new List<string>();
            //Также можно создать отдельный метод, который заменит Common.IsFailureSerious. Он будет находиться внутри класса Device
            for (int i = 0; i < devices.Length; i++)
                if (devices[i].isFailureSerious() && devices[i].checkDeadline(date))
                    result.Add(devices[i].getName());
            return result;
        }
           
    }
}
