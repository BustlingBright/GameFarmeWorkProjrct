using System;
using GameFramework.Fsm;
using GameFramework.Procedure;
using GameFramework.Network;
using UnityGameFramework.Runtime;
using System.IO;
using System.Net;

class AA : Packet
{
    public override int Id
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public override void Clear()
    {
        throw new NotImplementedException();
    }
}


class NetworkChannelHelper : INetworkChannelHelper
{
    public int PacketHeaderLength
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public Packet DeserializePacket(IPacketHeader packetHeader, Stream source, out object customErrorData)
    {
        throw new NotImplementedException();
    }

    public IPacketHeader DeserializePacketHeader(Stream source, out object customErrorData)
    {
        throw new NotImplementedException();
    }

    public void Initialize(INetworkChannel networkChannel)
    {
        throw new NotImplementedException();
    }

    public bool SendHeartBeat()
    {
        throw new NotImplementedException();
    }

    public bool Serialize<T>(T packet, Stream destination) where T : Packet
    {
        throw new NotImplementedException();
    }

    public void Shutdown()
    {
        throw new NotImplementedException();
    }
}


class ProcedureNetworkTest : ProcedureBase
{
    INetworkChannel m_channel;
    NetworkChannelHelper m_channelHelper = new NetworkChannelHelper();
    protected override void OnInit(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnInit(procedureOwner);
        m_channel = NetWorkManger.Instance._Instance.CreateNetworkChannel("test", m_channelHelper);
        m_channel.Connect(IPAddress.Parse("127.0.0.1"), 3306);
        m_channelHelper.s

    }
    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);
    }

    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
    }
}

