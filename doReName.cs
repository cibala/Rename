/*
 * Created by SharpDevelop.
 * User: dwang21
 * Date: 10/11/2017
 * Time: 13:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rename
{
	/// <summary>
	/// Description of doReName.
	/// </summary>
	public class doReName
	{
		public List<string> _inName = new List<string>();
		public List<string> _outName = new List<string>();
		public string _patt;
		private string _pattFormat;
		public string fullPath;
		public int nonRepFCnt;
        public int repeat;
			
		public doReName(){
		}
		public int getNonRepFileCnt(List<string> fileList){
			string pre_f = "";
			int cnt = 0;
			foreach(string inF in fileList){
				if(pre_f.Equals(Path.GetFileNameWithoutExtension(inF))){
					continue;
				}
				else{
					cnt++;
				}
				pre_f = Path.GetFileNameWithoutExtension(inF);
			}
			return cnt;
		}
		
		public int genNewNameList(List<string> _customSeq, int _snFromUI)
		{
			string _output;
			int sn = _snFromUI;
			string seq;
			string pre_inName = "";
            string _pattAfterHash;
			_outName.Clear();
            if(repeat <= 1) // <=1: no repeat
            {
                repeat = 0;
            }
            int repCnt = 1;

            // Calc. non-repeat file count
            //nonRepFCnt = getNonRepFileCnt(_inName);
            if (_customSeq.Count != 0){				
				if(_customSeq.Count < nonRepFCnt){
					MessageBox.Show("The file# doesn't match custom#", "Error");
					return -1;
				}
			}
			foreach(string inF in _inName){
				string ext = Path.GetExtension(inF);
                _output = inF;
                _pattAfterHash = _patt;
                // Rename the file with the same file name but diff. extension
                if (pre_inName.Equals(Path.GetFileNameWithoutExtension(inF))){
					_output = Path.GetFileNameWithoutExtension(_outName[_outName.Count -1]);
				}
				else{

                    if (_customSeq.Count == 0){
						seq = sn.ToString();
					}
					// use customized sequence
					else{
						seq = _customSeq[sn];
					}
                    // no special character
                    if ((false == _patt.Contains("*")) && (false == _patt.Contains("#")))
                    {
                        if (nonRepFCnt > 1) // fill sequence number
                        {
                            _pattFormat = "{0}_{1}";
                            _output = string.Format(_pattFormat, _patt, seq);
                        }
                        else
                        { // if there is only 1 non-repeat file, don't add SN after it
                            _pattFormat = "{0}";
                            _output = string.Format(_pattFormat, _patt);
                        }
                    }					
					else{                       
                        if (_patt.Contains("#"))
                        {
                            // multiple # case
                            if (_customSeq.Count == 0)
                            {
                                string[] padInfo = { "##", "D2" };
                                replaceHash(_patt, padInfo);
                                _pattFormat = _patt.Replace(padInfo[0], "{0}");
                                _output = string.Format(_pattFormat, Int32.Parse(seq).ToString(padInfo[1]));
                            }
                            else
                            { // single # or custom sequence case
                                _pattFormat = _patt.Replace("#", "{0}");
                                _output = string.Format(_pattFormat, seq);
                            }
                            _pattAfterHash = _output;
                        }
                        // add prefix or postfix (* case)
                        if (_pattAfterHash.Contains("*"))
                        {
                            _pattFormat = _pattAfterHash.Replace("*", "{0}");
                            _output = string.Format(_pattFormat, Path.GetFileNameWithoutExtension(inF));
                        }
                    }
                    if (repCnt < repeat)
                    {
                        _output += string.Format("_{0}", repCnt);
                        repCnt++;
                    } else
                    {
                        if(repeat > 0)
                        {
                            _output += string.Format("_{0}", repCnt);
                            repCnt = 1;
                        }
                        sn++;                       
                    }                    
				}
                /*if(repCnt < repeat)
                {
                    _output += string.Format("_{0}", repCnt);
                    repCnt++;
                }*/
                _output += ext;
				_outName.Add(_output);
				pre_inName = Path.GetFileNameWithoutExtension(inF);
			}
			return 0;
		}
		// return[0]: get ###..# patern; return[1]: D[number of #]
		private void replaceHash(string inString, string[] outString){
			int startIdx = inString.IndexOf('#');
			int endIdx = inString.LastIndexOf('#');
			int len = endIdx - startIdx+1;
			outString[0] = inString.Substring(startIdx, len);
			outString[1] = "D"+len.ToString();
		}
		
		public string getPreview(){
			string outPreview = "";
			for(int i=0; i<_inName.Count; i++){
				outPreview += string.Format( "{0} => {1}{2}", _inName[i], _outName[i], System.Environment.NewLine);
			}
			return outPreview;
		}
		public List<string> getCustomList(string inString){
			string tmp = inString.Trim();
			List<string> outList = new List<string>();
			if(tmp == ""){
				return outList;
			}
			else{
				String[] substrings = tmp.Split(',');
				foreach(var str in substrings){
					outList.Add(str);
				}
				return outList;
			}
		}
	}
}
