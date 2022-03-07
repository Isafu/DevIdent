using DevIdent.Classes;
using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

namespace DevIdent
{
    public class Network 
    {
        public static string[] networkInfoList = new string[] { "" };

        public static void GetNetworkInformation()
        {
            if (networkInfoList[0]?.Length != 0)
            {
                return;
            }
            string ip;
            try
            {
                ip = IPAddress.Parse(new WebClient().DownloadString("https://ipinfo.io/ip")).ToString();
            }
            catch
            {
                ip = " нет соединения с удаленным сервисом";
            }
            var adapters = NetworkInterface.GetAllNetworkInterfaces();
            Array.Resize(ref networkInfoList, adapters.Length + 2);
            networkInfoList[0] = "Кликните по тексту, чтобы получить доп. информацию о сети";
            for (int i = 1, j = 0; i < networkInfoList.Length && j < adapters.Length; i++, j++)
            {
                networkInfoList[i] = "Название подключения: " + adapters[j].Name;
            }
            networkInfoList[networkInfoList.Length - 1] = "IP-адрес: " + ip;
        }

        public static void GetAdvancedNetworkInformation()
        {
            string ip = "";
            try
            {
                ip = IPAddress.Parse(new WebClient().DownloadString("https://ipinfo.io/ip")).ToString();
            }
            catch
            {
                ip = "нет соединения с удаленным сервисом";
            }
            string[] adapterInfo = new string[12];
            string line = "";
            line = "IP-адрес: " + ip + "\n\n";
            foreach (var adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                adapterInfo[0] = string.IsNullOrEmpty(adapter.Name) ? "--" : "Название подключения: " + adapter.Name;
                adapterInfo[1] = string.IsNullOrEmpty(adapter.Description) ? "--" : "Описание: " + adapter.Description;
                adapterInfo[2] = string.IsNullOrEmpty(Convert.ToString(adapter.NetworkInterfaceType)) ? "--" : "Тип интерфейса: " + adapter.NetworkInterfaceType;
                adapterInfo[3] = adapter.GetIPv4Statistics().BytesSent > 0 ? "Байт отправлено: " + adapter.GetIPv4Statistics().BytesSent.ToString() : "--";
                adapterInfo[4] = adapter.GetIPv4Statistics().BytesReceived > 0 ? "Байт получено: " + adapter.GetIPv4Statistics().BytesReceived.ToString() : "--";
                adapterInfo[5] = string.IsNullOrEmpty(Convert.ToString(adapter.GetPhysicalAddress())) ? "--" : "MAC-адрес: " + adapter.GetPhysicalAddress().ToString();
                adapterInfo[6] = string.IsNullOrEmpty(string.Join(", ", adapter.GetIPProperties().DhcpServerAddresses)) ? "--"
                    : "DHCP-адреса серверов: " + string.Join(", ", adapter.GetIPProperties().DhcpServerAddresses);
                adapterInfo[7] = adapter.GetIPProperties().IsDnsEnabled ? "DNS статус: включен" : "DNS статус: выключен";
                adapterInfo[8] = string.IsNullOrEmpty(string.Join(", ", adapter.GetIPProperties().DnsAddresses)) ? "--"
                    : "DNS-адреса серверов: " + string.Join(", ", adapter.GetIPProperties().DnsAddresses);
                adapterInfo[9] = adapter.GetIPProperties().IsDynamicDnsEnabled ? "Статус динамического DNS: включен" : "Статус динамического DNS: выключен";
                adapterInfo[10] = adapter.IsReceiveOnly ? "Интерфейс настроен только на получение трафика" : "--";
                adapterInfo[11] = string.IsNullOrEmpty(Convert.ToString(adapter.Speed))
                    ? "--" : "Скорость интерфейса: " + Math.Round(adapter.Speed * 0.000001, 1) + " Мб/С";
                string[] newAdapterInfo = adapterInfo.Where(x => !x.StartsWith("--")).ToArray();
                line += string.Join(Environment.NewLine, newAdapterInfo);
                line += "\n\n";
            }
            NotepadMessager.SendMessage(line);
        }
    }
}
