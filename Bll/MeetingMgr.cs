using System;
using System.Collections.Generic;
using System.Linq;
using Dal;
using Dal.models;
using Dal.pgDB;
namespace Bll
{
    public class MeetingMgr : IMeetingMgr
    {
        private readonly IRepository<Meeting> _meetingRepository;
        public MeetingMgr()
        {
            _meetingRepository = new PgRepository<Meeting>();
        }
        public void Add(Meeting meeting)
        {
            _meetingRepository.Add(meeting);
        }

        public void Edit(Meeting meeting)
        {
            Meeting existingMeeting = _meetingRepository.Find().First(p => p.PostId == meeting.PostId);
            existingMeeting.Start = meeting.Start;
            existingMeeting.End = meeting.End;
            existingMeeting.LastModificationDate = DateTime.Now.ToUniversalTime();
            _meetingRepository.Update();
        }

        public List<Meeting> Find(Meeting meeting)
        {
            var q = _meetingRepository.Find();
            if (meeting.PostId != null)
            {
                return q.Where(p => p.PostId == meeting.PostId).ToList();
            }
            return q.ToList();
        }

        public void Remove(Guid id)
        {
            Meeting existingMeeting = _meetingRepository.Find().First(p => p.PostId == id);
            _meetingRepository.Delete(existingMeeting);
        }
        
        public void Finish(Guid id)
        {
            // get the targeted meeting
            Meeting existingMeeting = _meetingRepository.Find().First(p => p.PostId == id);
            existingMeeting.End = DateTime.Now.ToUniversalTime();

            // update status flag to be closed
            existingMeeting.Status = MeetingStatus.Finished;
            _meetingRepository.Update();
        }
        
        public void Start(Guid id)
        {
            // get the targeted meeting
            Meeting existingMeeting = _meetingRepository.Find().First(p => p.PostId == id);
            existingMeeting.Start = DateTime.Now.ToUniversalTime();

            // update status flag to be started
            existingMeeting.Status = MeetingStatus.Started;
            _meetingRepository.Update();
        }
    }
}