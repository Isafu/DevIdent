using DevIdent.Classes;
using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

namespace DevIdent
{
    public static class Network
    {
        public static readonly string[] networkInfoList = { "" };

        public static void GetNetworkInformation()
        {
            if (networkInfoList[0]?.Length != 0)
            {
                return;
            }
            string ip = "";
            try
            {
                ip = IPAddress.Parse(new WebClient().DownloadString("https://ipinfo.io/ip")).ToString();
            }
            catch
            {
                ip = " нет соединения с удаленным сервисом";
            }
            var adapters = NetworkInterface.GetAllNetworkInterfaces();
            networkInfoList[0] = "Все доступные сетевые подключения: " +
                Environment.NewLine + Environment.NewLine + string.Join(Environment.NewLine, adapters
                .Select(x => "Название подключения: " + x.Name + Environment.NewLine
                + "Байт отправлено: " + x.GetIPv4Statistics().BytesSent + " || Байт получено: "
                + x.GetIPv4Statistics().BytesReceived + Environment.NewLine))
                + Environment.NewLine + "IP-адрес: "
                + ip + Environment.NewLine + Environment.NewLine + "Кликните по тексту, чтобы получить доп. информацию о сети" + Environment.NewLine;
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
                ip = " нет соединения с удаленным сервисом";
            }
            var adapters = NetworkInterface.GetAllNetworkInterfaces();
            string[] adapterInfo = new string[12];
            string line = "";
            foreach (var adapter in adapters)
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
                adapterInfo[9] = adapter.GetIPProperties().IsDynamicDnsEnabled ? "Статус динамического DNS : включен" : "Статус динамического DNS : выключен";
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
