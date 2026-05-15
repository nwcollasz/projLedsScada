        private void timerFade_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.40; 
            else
                timerFade.Stop();
        }